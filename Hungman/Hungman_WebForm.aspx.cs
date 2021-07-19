using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;


namespace Hungman_Game__HW2
{
    public partial class Hungman_WebForm : System.Web.UI.Page
    {
        string word;
        string secret;
        string maskedWord;
        int attemptCount = 5;

        protected void Page_Load(object sender, EventArgs e)
        {
            /* Submitting the ASP.NET page to the server for processing*/
            if (!IsPostBack)
            {
                Hungman();

            }
            /*Perform the actions that are common to all requests, database query */
            else
            {
                word = (string)ViewState["word"];
                secret = (string)ViewState["secret"];
                maskedWord = (string)ViewState["maskedWord"];
                attemptCount = (int)ViewState["attemptCount"];
            }

        }
        /* Perform any updates before the output is rendered. */
        protected void Page_PreRender(Object sender, EventArgs e)
        {
            ViewState["word"] = word;
            ViewState["secret"] = secret;
            ViewState["maskedWord"] = maskedWord;
            ViewState["attemptCount"] = attemptCount;
        }

        /*The class to run the game*/
         protected void Hungman()
         {
             A.Enabled = true; B.Enabled = true; C.Enabled = true; D.Enabled = true; E.Enabled = true;
             F.Enabled = true; G.Enabled = true; H.Enabled = true; I.Enabled = true; J.Enabled = true;
             K.Enabled = true; L.Enabled = true; M.Enabled = true; N.Enabled = true; O.Enabled = true;
             P.Enabled = true; Q.Enabled = true; R.Enabled = true; S.Enabled = true; T.Enabled = true;
             U.Enabled = true; V.Enabled = true; W.Enabled = true; X.Enabled = true; Y.Enabled = true;
             Z.Enabled = true; btnPlay.Enabled = false;
             
            attemptCount =6;
            image1.ImageUrl = "~/images/0.jpg";
            /* Creating Array List where to store the name and the hint attributes*/
            ArrayList secret_words = new ArrayList();
             ArrayList explained_words = new ArrayList();

             Random random = new Random();
            /*By using exeption handeling, load the Xml file and display in specific labels the attributes name and hint of the element phrase*/
             try
             {
                 XmlDocument xDocument = new XmlDocument();
                 xDocument.Load(Server.MapPath("DataSet.xml"));
                 XmlNodeList xNode = xDocument.SelectNodes("Phrases/phrase");
                 foreach (XmlNode dataline in xNode)
                 {

                     secret_words.Add(dataline.Attributes["name"].Value.ToString());
                     explained_words.Add(dataline.Attributes["hint"].Value.ToString());

                 }

                 /*Storing into a string the secret and explained words*/
                 string[] findss = secret_words.ToArray(typeof(string)) as string[];
                 string[] hintss = explained_words.ToArray(typeof(string)) as string[];
                 int _random = random.Next(findss.Length);

                 secret = hintss[_random];
                 lblHint.Text = secret;

                 word = findss[_random];
                 maskedWord = word;
                /*Using regular expression to mask the word*/
                 maskedWord = Regex.Replace(word, "[A-z]", "-");
                 lblWord.Text = maskedWord;
                 lblMessage.Text = "Lives left: ";
                 lblAttemps.Text = attemptCount.ToString();
                 lblResult.Text = "";

             }
             catch (Exception ex)
             {
                 lblWord.Text = "Cannot read the file " + ex;
             }

         }

        protected void LetterGuessed(object sender, EventArgs e)
        {

            if (attemptCount != 0 && (lblResult.Text.Equals("")))
            {
                string letter = ((Control)sender).ID.ToString().ToLower();
                Button btn = (Button)sender;
                btn.Enabled = false;
                int startPosition = word.IndexOf(letter);
                /*When the letter is guessed right*/
                if (!(startPosition == -1))
                {
                    do
                    {
                        maskedWord = maskedWord.Remove(startPosition, 1).Insert(startPosition, letter);
                        lblWord.Text = maskedWord;
                        startPosition = word.IndexOf(letter, startPosition + 1);
                    }
                    while (startPosition != -1);
                }
                /*If the letter is guessed wrong the parts of the pictures are drawn*/
                else
                {
                    attemptCount--;
                    if (attemptCount == 5)
                    {
                        image1.ImageUrl = "~/images/1.jpg";

                    }
                    if (attemptCount == 4)
                    {
                        image1.ImageUrl = "~/images/2.jpg";

                    }
                    if (attemptCount == 3)
                    {
                        image1.ImageUrl = "~/images/3.jpg";
                    }
                    if (attemptCount == 2)
                    {
                        image1.ImageUrl = "~/images/4.jpg";
                    }
                    if (attemptCount == 1)
                    {
                        image1.ImageUrl = "~/images/5.jpg";
                    }
                    if (attemptCount == 0)
                    {
                        image1.ImageUrl = "~/images/6.jpg";
                    }
                    lblAttemps.Text = attemptCount.ToString();
                }
                /*If the word is guessed correct*/
                if (maskedWord.Equals(word))
                {
                    btnPlay.Enabled = true;
                    lblWord.Text = word;
                    lblResult.Text = "You Won";
                    lblMessage.Text = "PLAY AGAIN";
                    lblAttemps.Text = "";
                }

                /*If the word is not guessed right and if the number of lives is 0*/
                if (attemptCount == 0 && !(maskedWord.Equals(word)))
                {
                    lblResult.Text ="TRY AGAIN!";
                    lblWord.Text = word;
                    btnPlay.Enabled = true;
                    lblMessage.Text = "DEAD :(";
                    lblAttemps.Text = "";
                }

            }
            else
            {
                //Do nothing on letter button click
            }
        }
       
        /*Button when clicking the Play Button*/
        protected void btnPlay_Click(object sender, EventArgs e)
        {
            Hungman();
        }

        /*Button when Adding a new word*/
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
            XmlDocument doc = new XmlDocument();

            doc.Load(Server.MapPath("~/DataSet.xml"));

            XmlElement ParentElement = doc.CreateElement("phrase");

            XmlAttribute Name = doc.CreateAttribute("name");

            Name.InnerText = txtName.Text;
            doc.DocumentElement.SetAttributeNode(Name);

            XmlAttribute Hint= doc.CreateAttribute("hint");

            Hint.InnerText = txtHint.Text;

            doc.DocumentElement.SetAttributeNode(Hint);

            doc.Save(Server.MapPath("~/DataSet.xml"));



        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            
        }
    }
}