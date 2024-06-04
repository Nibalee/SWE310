using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignemnt1
{
    public partial class chatbotPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String userInput = TextBox1.Text; //save the input value to userInput
            Label1.Text = GetResponse(userInput); //put returned response in label text
            TextBox1.Text = ""; //Empty the text box for the 
                                //user to facilitate the input of the next question
        }

        //A function to return the correspondent response based on the user input
        private string GetResponse(string input)
        {
            string response;
            switch (input.ToLower())
            {
                case "what is a star?":
                    response = "A star is a giant ball of hot gas, mostly hydrogen and helium, that produces light and heat from nuclear reactions in its core.";
                    break;

                case "what is the sun?":
                    response = "The Sun is the star at the center of our Solar System. It provides the energy that supports life on Earth.";
                    break;

                case "what is a planet?":
                    response = "A planet is a large object that orbits a star and is big enough to be rounded by its own gravity.";
                    break;

                case "what is the solar system?":
                    response = "The Solar System is a group of planets and other objects that orbit the Sun.";
                    break;

                case "what is the moon?":
                    response = "The Moon is Earth's only natural satellite. It orbits Earth and reflects sunlight.";
                    break;

                case "what is a galaxy?":
                    response = "A galaxy is a massive system of stars, planets, and other objects bound together by gravity.";
                    break;

                case "what is the milky way?":
                    response = "The Milky Way is the galaxy that includes our Solar System. It appears as a milky band of light in the sky.";
                    break;

                case "what is a comet?":
                    response = "A comet is a small, icy object that orbits the Sun. It has a bright coma and tail when it gets close to the Sun.";
                    break;

                case "what is an asteroid?":
                    response = "An asteroid is a small rocky object that orbits the Sun, mostly found in the asteroid belt between Mars and Jupiter.";
                    break;

                case "what is a black hole?":
                    response = "A black hole is a region in space where gravity is so strong that not even light can escape from it.";
                    break;

                case "what is a nebula?":
                    response = "A nebula is a giant cloud of gas and dust in space where new stars are born.";
                    break;

                case "what is a supernova?":
                    response = "A supernova is a powerful explosion that happens when a star runs out of fuel and collapses.";
                    break;

                case "what is a space telescope?":
                    response = "A space telescope is a telescope that is placed in space to get clear images of the universe without interference from Earth's atmosphere.";
                    break;

                case "what is the big bang?":
                    response = "The Big Bang is the event that started the universe about 13.8 billion years ago, causing it to expand from a very small, hot, and dense state.";
                    break;

                case "what is an alien?":
                    response = "An alien is a hypothetical creature from another planet. There is no confirmed evidence of alien life yet.\r\n";
                    break;

                default:
                    response = "I'm sorry, I didn't understand that. Can you try with another question!";
                    break;
            }

            return response;
        }

    }
}