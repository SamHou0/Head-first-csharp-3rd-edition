using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hide_and_seek
{
    public partial class House : Form
    {
        private Location currentLocation;

        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;

        OutsideWithHidingPlace garden;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace driveway;

        RoomWithHidingPlace stairs;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        RoomWithHidingPlace bathRoom;

        Opponent opponent;

        int moves;
        public House()
        {
            InitializeComponent();

            CreateObjects();
            ResetGame();
        }

        private void MoveToNewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            RedrawForm();
        }

        private void CreateObjects()
        {
            livingRoom = new("Living Room", "an antique carpet", "an oak door with a brass knob","in the closet");
            diningRoom = new("Dining Room", "a crystal light");
            kitchen = new("Kitchen", "stainless steel tableware", "a screen door","in the closet");

            garden = new("Garden", false,"inside the shed");
            frontYard = new("Front Yard", false, "an oak door with a brass knob");
            backYard = new("Back Yard", true, "a screen door");
            driveway = new("Driveway", false, "in the garage");

            stairs = new("Stairs", "a picture with a dog and a closet", "in a picture with a dog and a closet");
            masterBedroom = new("Master Bedroom", "a bed", "under the bed");
            secondBedroom = new("Second Bedroom", "a bed", "under the bed");
            bathRoom = new("Bathroom", "a bathtub and a toilet", "in the bathtub");

            livingRoom.Exits = new Location[] { kitchen,stairs };
            diningRoom.Exits = new Location[] { kitchen, livingRoom };
            kitchen.Exits = new Location[] { diningRoom };

            garden.Exits = new Location[] { frontYard, backYard };
            frontYard.Exits = new Location[] { garden,driveway };
            backYard.Exits = new Location[] { garden,driveway };
            driveway.Exits = new Location[] {frontYard, backYard };

            stairs.Exits = new Location[] {livingRoom,masterBedroom,secondBedroom,bathRoom};
            masterBedroom.Exits = new Location[] {stairs};
            secondBedroom.Exits = new Location[] {stairs};
            bathRoom.Exits = new Location[] {stairs };

            livingRoom.DoorLocation = frontYard;
            kitchen.DoorLocation = backYard;
            frontYard.DoorLocation = livingRoom;
            backYard.DoorLocation = kitchen;

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            MoveToNewLocation(currentLocation.Exits[exitBox.SelectedIndex]);
            moves++;
        }

        private void GoThroughDoorButton_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasExteriorDoor = currentLocation as IHasExteriorDoor;
            MoveToNewLocation(hasExteriorDoor.DoorLocation);
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if(opponent.Check(currentLocation))
            {
                MessageBox.Show("You found me in " + moves + " moves!");
                ResetGame();
            }
        }
        private void ResetGame()
        {
            description.Text = "";
            moves=0;
            opponent = new(frontYard);
            goButton.Visible = false;
            exitBox.Visible = false;
            goThroughDoorButton.Visible = false;
            checkButton.Visible = false;
            hideButton.Visible = true;
        }
        private void RedrawForm()
        {
            exitBox.Items.Clear();
            foreach (Location exit in currentLocation.Exits)
            {
                exitBox.Items.Add(exit.Name);
            }
            exitBox.SelectedIndex = 0;
            description.Text = currentLocation.Description;
            if (currentLocation is IHasExteriorDoor)
                goThroughDoorButton.Visible = true;
            else
                goThroughDoorButton.Visible = false;
            if (currentLocation is IHidingPlace)
            {
                checkButton.Visible = true;
                IHidingPlace hidingPlace=currentLocation as IHidingPlace;
                checkButton.Text = "Check " + hidingPlace.HidePlace;
            }
            else
                checkButton.Visible = false;
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            hideButton.Visible = false;
            for (int i = 0; i < 10; i++)
            {
                description.Text = i.ToString()+"···";
                opponent.Move();
                Application.DoEvents();
                Thread.Sleep(200);
            }
            description.Text = "Ready or not,here I come!";
            Application.DoEvents();
            Thread.Sleep(500);
            goButton.Visible = true;
            exitBox.Visible = true;
            MoveToNewLocation(livingRoom);
        }
    }
}
