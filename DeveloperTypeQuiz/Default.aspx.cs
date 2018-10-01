using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace firstProject1
{   




    public class Results
    {

         public decimal frontEndScore { get; set; }
         public decimal backEndScore { get; set; }





    }

    public class Choices
    {

    

       public  String[] choice1Array = { " Taking a sketch or a mock-up and trurning it into reality by translating it into front-end code. ",
                                 "  What the user sees and interects with on digital platforms through mark-up.",
                                 " Making a website that leaves an impact on the user by making their experience satisfying and simple.",
                                 " Client-Side.",
                                 " Look good and provide an awesome experience.",
                                 " Creating new styles to cover up any mess made by the functionality.",
                                 " Creative, imaginitive, innovative and empathic.",
                                 " Sitting in front of a huge monitor and a MacBook Pro, Redbull in hand and wearing a graphic t-shirt and skinny jeans.",
                              
                                };

      public  String[] choice2Array = { " Thinking about how to model data and figuring out Algorithms. ",
                                 " Manipulate data.",
                                 " Writing Efficient Algorithms and making a complex system faster.",
                                 " Server-side.",
                                 " Be dynamic, fast and with a robust architecture.",
                                 " Getting functionality out of the door no matter if you break up the styling.",
                                 " Detail oriented, handle complixity, analytical and logical.",
                                 " Surrounded by empty coffee cups, in front of an old school but a powerful laptop, comfortable in your hoodie and Cargo pants. ",
                                 
                                };

    }


    public partial class _Default : Page

    {


        static int i = 0;
        static int frontEndResults = 0;
        static int backEndResults = 0;
        Choices theChoices = new Choices();
        Results theResults = new Results();


        protected void Page_Load(object sender, EventArgs e)
        {



            if (!Page.IsPostBack)
            {
                i = 0;
                backEndResults = 0;
                frontEndResults = 0;

            }


        }

        protected void ButtonStart_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
            nextButton.Visible = true;
            previousButton.Visible = true;
            RBL.Visible = true;

            RBL.Items[0].Text = theChoices.choice1Array[i];

            RBL.Items[1].Text = theChoices.choice2Array[i];



        }

        protected void RestartButton_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
            i = 0;
            backEndResults = 0;
            frontEndResults = 0;
            RestartButton.Visible = false;
            RBL.ClearSelection();


        }

        protected void PreviousButton_Click(object sender, EventArgs e)
        {

            

            if (RBL.SelectedValue == "fE")
            { frontEndResults--; }

            else if (RBL.SelectedValue == "bE")
            { backEndResults--; }


            if ( MultiView1.ActiveViewIndex != 1)
            {
                i--;
            }


            MultiView1.ActiveViewIndex--;

            if (MultiView1.ActiveViewIndex == 0)
            {
                previousButton.Visible = false;
                nextButton.Visible = false;
                RBL.Visible = false;
              

            }

            else if (MultiView1.ActiveViewIndex == 8)
            {
                previousButton.Visible = true;
                nextButton.Visible = false;
                RBL.Visible = true;
                finishedButton.Visible = true;
            }

            else
            {

                previousButton.Visible = true;
                nextButton.Visible = true;
                finishedButton.Visible = false;

            }

           
            RBL.Items[0].Text = theChoices.choice1Array[i];

            RBL.Items[1].Text = theChoices.choice2Array[i];

          
            RBL.ClearSelection();


        }









        protected void NextButton_Click(object sender, EventArgs e)

        {

            
            if (Page.IsValid)
            {


                if (i < theChoices.choice1Array.Length)
                {
                    i++;
                }


                MultiView1.ActiveViewIndex++;

                if (MultiView1.ActiveViewIndex == 8)
                {
                    
                    nextButton.Visible = false;

                    finishedButton.Visible = true;

                }

                else
                {

                    previousButton.Visible = true;
                    nextButton.Visible = true;
                }






                RBL.Items[0].Text = theChoices.choice1Array[i];

                RBL.Items[1].Text = theChoices.choice2Array[i];






                if (RBL.SelectedValue == "fE")
                { frontEndResults++; }

                else if (RBL.SelectedValue == "bE")
                { backEndResults++; }


                RBL.ClearSelection();


            }

        }

        protected void finishedButton_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 9;

            RestartButton.Visible = true;

            previousButton.Visible = false;
            nextButton.Visible = false;
            RBL.Visible = false;
            finishedButton.Visible = false;
            resultsMessage.Visible = true;

            if (RBL.SelectedValue == "fE")
            { frontEndResults++; }

            else if (RBL.SelectedValue == "bE")
            { backEndResults++; }



            


            theResults.frontEndScore = Convert.ToDecimal(frontEndResults * Convert.ToDecimal(100 / (theChoices.choice1Array.Length)));
            theResults.backEndScore = Convert.ToDecimal(backEndResults * Convert.ToDecimal(100 / (theChoices.choice1Array.Length)));

            

            drawChart(theResults);


            if (frontEndResults>backEndResults)
            {
                resultsMessage.Text = "You're Definitely a Front-Ender!";

            }

            else if (frontEndResults < backEndResults)
            {

                resultsMessage.Text = "You're Definitely a Back-Ender!";

            }

            else
            {
                resultsMessage.Text = "Congratulations ! you're suited to do both.";
            }
        }

        void drawChart(Results theResults)
        {
            ClientScriptManager cs = Page.ClientScript;
            cs.RegisterStartupScript(this.GetType(), "anything", "draw('" + theResults.frontEndScore + "','"
                                                                                    + theResults.backEndScore
                                                                                    + "');", true);
        }

        
    }



    }

