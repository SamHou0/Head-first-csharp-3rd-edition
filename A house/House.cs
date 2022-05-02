using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_house
{
    public partial class House : Form
    {
        private Location currentLocation;
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        Outside garden;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        public House()
        {
            InitializeComponent();

            CreateObjects();
            MoveToNewLocation(livingRoom);
        }

        private void MoveToNewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            exitBox.Items.Clear();
            foreach (Location exit in newLocation.Exits)
            {
                exitBox.Items.Add(exit.Name);
            }
            exitBox.SelectedIndex = 0;
            description.Text = currentLocation.Description;
            if (currentLocation is IHasExteriorDoor)
                goThroughDoorButton.Visible = true;
            else
                goThroughDoorButton.Visible = false;
        }

        private void CreateObjects()
        {
            livingRoom = new("Living Room", "an antique carpet", "an oak door with a brass knob");
            diningRoom = new("Dining Room", "a crystal light");
            kitchen = new("Kitchen", "stainless steel tableware", "a screen door");
            garden = new("Garden", false);
            frontYard = new("Front Yard", false, "an oak door with a brass knob");
            backYard = new("Back Yard", true, "a screen door");

            livingRoom.Exits = new Location[] { kitchen };
            diningRoom.Exits = new Location[] { kitchen, livingRoom };
            kitchen.Exits = new Location[] { diningRoom };
            garden.Exits = new Location[] { frontYard, backYard };
            frontYard.Exits = new Location[] { garden };
            backYard.Exits = new Location[] { garden };

            livingRoom.DoorLocation = frontYard;
            kitchen.DoorLocation = backYard;
            frontYard.DoorLocation = livingRoom;
            backYard.DoorLocation = kitchen;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            MoveToNewLocation(currentLocation.Exits[exitBox.SelectedIndex]);

        }

        private void goThroughDoorButton_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasExteriorDoor = currentLocation as IHasExteriorDoor;
            MoveToNewLocation(hasExteriorDoor.DoorLocation);
        }
    }
}
