using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideAndSeek
{
    public partial class Form1 : Form
    {
        // Instanciando Objetos
        Location currentLocation;
        Location locationsToHide;
        Hallway pasilloSeccionUno;
        Hallway pasilloSeccionDos;
        Hallway pasilloSeccionTres;
        HallwayDoors pasilloUno;
        HallwayDoors pasilloDos;
        HallwayDoors pasilloTres;
        HallwayDoors pasilloCuatro;
        HallwayDoors pasilloCinco;
        RoomsDoor habitacionUno;
        RoomsDoor habitacionDos;
        RoomsDoor habitacionTres;
        RoomsDoor habitacionCuatro;
        RoomsDoor habitacionCinco;
        RoomsDoor habitacionSeis;
        RoomsDoor habitacionSiete;
        RoomsDoor habitacionOcho;
        RoomsDoor habitacionNueve;
        RoomsDoor habitacionDiez;
        RoomsDoor habitacionOnce;

        // Random para esconder jugador
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            CreateRooms();
            MoveToNewLocation(pasilloSeccionUno);
        }
        
        private void CreateRooms()
        {
            pasilloSeccionUno = new Hallway("Primera sección del pasillo", 32, 135);
            pasilloSeccionDos = new Hallway("Segunda sección del pasillo", 259, 135);
            pasilloSeccionTres = new Hallway("Tercera seccion del pasillo", 464, 135);
            pasilloUno = new HallwayDoors("Pasillo 1", 91, 58);
            pasilloDos = new HallwayDoors("Pasillo 2", 170, 221);
            pasilloTres = new HallwayDoors("Pasillo 3", 269, 53);
            pasilloCuatro = new HallwayDoors("Pasillo 4", 403, 219);
            pasilloCinco = new HallwayDoors("Pasillo 5", 506, 50);
            habitacionUno = new RoomsDoor("Habitación 1", 26, 56);
            habitacionDos = new RoomsDoor("Habitación 2", 151, 32);
            habitacionTres = new RoomsDoor("Habitación 3", 202, 82);
            habitacionCuatro = new RoomsDoor("Habitación 4", 351, 56);
            habitacionCinco = new RoomsDoor("Habitación 5", 436, 30);
            habitacionSeis = new RoomsDoor("Habitación 6", 555, 53);
            habitacionSiete = new RoomsDoor("Habitación 7", 504, 236);
            habitacionOcho = new RoomsDoor("Habitación 8", 312, 198);
            habitacionNueve = new RoomsDoor("Habitación 9", 312, 262);
            habitacionDiez = new RoomsDoor("Habitación 10", 79, 209);
            habitacionOnce = new RoomsDoor("Habitación 11", 96, 260);

            pasilloSeccionUno.Exists = new Location[] { pasilloSeccionDos, pasilloSeccionTres, pasilloUno, pasilloDos };
            pasilloUno.Exists = new Location[] { habitacionUno, habitacionDos, pasilloSeccionUno };
            habitacionUno.Exists = new Location[] { pasilloUno };
            habitacionDos.Exists = new Location[] { pasilloUno };
            pasilloDos.Exists = new Location[] { habitacionOcho, habitacionDiez, habitacionOnce, pasilloSeccionUno };
            habitacionOcho.Exists = new Location[] { pasilloDos };
            habitacionDiez.Exists = new Location[] { pasilloDos };
            habitacionOnce.Exists = new Location[] { pasilloDos };
            pasilloSeccionDos.Exists = new Location[] { pasilloSeccionUno, pasilloSeccionTres, pasilloTres, pasilloCuatro };
            pasilloTres.Exists = new Location[] { habitacionTres, habitacionCuatro, pasilloSeccionDos };
            habitacionTres.Exists = new Location[] { pasilloTres };
            habitacionCuatro.Exists = new Location[] { pasilloTres };
            pasilloCuatro.Exists = new Location[] { habitacionSiete, habitacionNueve, pasilloSeccionDos };
            habitacionSiete.Exists = new Location[] { pasilloCuatro };
            habitacionNueve.Exists = new Location[] { pasilloCuatro };
            pasilloSeccionTres.Exists = new Location[] { pasilloSeccionDos, pasilloSeccionUno, pasilloCinco };
            pasilloCinco.Exists = new Location[] { pasilloSeccionTres, habitacionSeis, habitacionCinco };
            habitacionCinco.Exists = new Location[] { pasilloCinco };
            habitacionSeis.Exists = new Location[] { pasilloCinco };

            locationsToHide.Exists = new Location[] { habitacionUno, habitacionDos, habitacionTres, habitacionCuatro, habitacionCinco, habitacionSeis, habitacionSiete, habitacionOcho, habitacionNueve, habitacionDiez, habitacionOnce };
        }

        private void MoveToNewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            pictureBoxPlayer.Location = new Point(newLocation.X, newLocation.Y);

            comboBoxExist.Items.Clear();
            for (int i = 0; i < currentLocation.Exists.Length; i++)
            {
                comboBoxExist.Items.Add(currentLocation.Exists[i].Name);
                comboBoxExist.SelectedIndex = 0;
            }// End For

            textBoxInstructions.Text = currentLocation.Description;

            if (currentLocation is WithDoor)
            {
                buttonOpenDoor.Visible = true;

                if(currentLocation == habitacionUno || currentLocation == habitacionDos || currentLocation == habitacionTres || currentLocation == habitacionCuatro || currentLocation == habitacionCinco || currentLocation == habitacionSeis || currentLocation == habitacionSiete || currentLocation == habitacionOcho || currentLocation == habitacionNueve || currentLocation == habitacionDiez || currentLocation == habitacionOnce)
                {
                    buttonGoTo.Visible = false;
                }
                else
                {
                    buttonGoTo.Visible = true;
                }
            }
            else
            {
                buttonOpenDoor.Visible = false;

                if (currentLocation == habitacionUno || currentLocation == habitacionDos || currentLocation == habitacionTres || currentLocation == habitacionCuatro || currentLocation == habitacionCinco || currentLocation == habitacionSeis || currentLocation == habitacionSiete || currentLocation == habitacionOcho || currentLocation == habitacionNueve || currentLocation == habitacionDiez || currentLocation == habitacionOnce)
                {
                    buttonGoTo.Visible = false;
                }
                else
                {
                    buttonGoTo.Visible = true;
                }
            }// End If
        }

        private void buttonGoTo_Click(object sender, EventArgs e)
        {
            Location futureLocation = currentLocation.Exists[comboBoxExist.SelectedIndex];

            if (futureLocation == habitacionUno || futureLocation == habitacionDos || futureLocation == habitacionTres || futureLocation == habitacionCuatro || futureLocation == habitacionCinco || futureLocation == habitacionSeis || futureLocation == habitacionSiete || futureLocation == habitacionOcho || futureLocation == habitacionNueve || futureLocation == habitacionDiez || futureLocation == habitacionOnce)
            {

            }
            else
            {
                MoveToNewLocation(currentLocation.Exists[comboBoxExist.SelectedIndex]);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string desc = "Debes encontrar al otro jugador, se ha escondido y tienes 5 intentos para encontrarlo!";
            desc += Environment.NewLine + "Cada puerta que abres es una oportunidad que pierdes!";
            desc += Environment.NewLine + "Para que el jugador 2 se esconda presiona en el botón de 'Iniciar juego'";
            desc += Environment.NewLine;
            desc += Environment.NewLine + "Para recorrer los pasillos, se evalua si existen puertas de acceso, y permite";
            desc += " visitar los diferentes ambientes, en base a la posición de la persona.";
            MessageBox.Show(desc, "¿Cuál es el objetivo de la aplicación?", MessageBoxButtons.OK);
        }

        private void buttonOpenDoor_Click(object sender, EventArgs e)
        {
            Location futureLocation = currentLocation.Exists[comboBoxExist.SelectedIndex];

            if (futureLocation == habitacionUno || futureLocation == habitacionDos || futureLocation == habitacionTres || futureLocation == habitacionCuatro || futureLocation == habitacionCinco || futureLocation == habitacionSeis || futureLocation == habitacionSiete || futureLocation == habitacionOcho || futureLocation == habitacionNueve || futureLocation == habitacionDiez || futureLocation == habitacionOnce)
            {
                MoveToNewLocation(currentLocation.Exists[comboBoxExist.SelectedIndex]);
            }
            else if(currentLocation == habitacionUno || currentLocation == habitacionDos || currentLocation == habitacionTres || currentLocation == habitacionCuatro || currentLocation == habitacionCinco || currentLocation == habitacionSeis || currentLocation == habitacionSiete || currentLocation == habitacionOcho || currentLocation == habitacionNueve || currentLocation == habitacionDiez || currentLocation == habitacionOnce)
                MoveToNewLocation(currentLocation.Exists[comboBoxExist.SelectedIndex]);
            else
            {

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int random = rand.Next(0, 10);

            Location newLocationToHide = locationsToHide.get(random);
        }
    }
}
