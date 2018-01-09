using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.System;
using SFML.Window;
using SFML.Graphics;
using SFML.Audio;

namespace FlynnFightersSFML.FlynnFighters
{
    class Game
    {
        RenderWindow m_RenderWindow;
        Color m_ClearColour = Color.Red;

        public Game()
        {

        }

        static void onClose(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Close();
        }

        public void RunGame()
        {   
            m_RenderWindow = new RenderWindow(new VideoMode(800, 600), "Test");
            m_RenderWindow.Closed += new EventHandler(onClose);

            while(m_RenderWindow.IsOpen)
            {
                m_RenderWindow.DispatchEvents();
                m_RenderWindow.Clear(m_ClearColour);
                m_RenderWindow.Display();
            }
        }
    }
}
