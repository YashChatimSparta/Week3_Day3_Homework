using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WarriorsXLibrary;

namespace WarriorX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player player = new Player();
        Movement movement = new Movement();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void CalculateYCoordinate(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Name == "buttonUpArrow")
            {
                messageYCoordinate.Text = movement.jump().ToString();
            }

            else if (btn.Name == "buttonDownArrow")
            {
                messageYCoordinate.Text = movement.duck().ToString();
            }
        }

        public void CalculateXCoordinate(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Name == "buttonRightArrow")
            {
                messageXCoordinate.Text = movement.moveRight().ToString();
            }

            else if (btn.Name == "buttonLeftArrow")
            {
                messageXCoordinate.Text = movement.moveLeft().ToString();
            }
        }

        public void CalculateHealth(object sender, EventArgs e)
        {
            messageHealth.Text = player.takeDamage().ToString();

            if (messageHealth.Text == "0")
            {
                MessageBox.Show("Health = " + messageHealth.Text + ", Player is dead!!!");
                ChangeToEndScene();
            }
        }

        public void ChangeToEndScene()
        {
            var newForm = new EndWindow(); //create your new form.
            newForm.Show(); //show the new form.
            this.Close(); //only if you want to close the current form.
        }
    }
}
