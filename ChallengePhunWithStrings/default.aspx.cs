using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ChallengePhunWithStrings
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            string name = "Bob Tabor";
            // In my case, the result would be:
            // robaT boB
            lblOrginalName.Text = "Tony Bateman";
            char[] inputarray = lblOrginalName.Text.ToString().ToCharArray();
            Array.Reverse(inputarray);
            lblReverseName.Text  = new string(inputarray);



            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke

            //Use split:
            string[] starSequence = names.Split(',');
            int ssLength = starSequence.Length;
            string[] reverseStarSequence = new string[ssLength];

            
 
            for(int i = starSequence.Length-1; i >= 0; --i)
            {
                int indexSequence = ssLength - i-1;
                reverseStarSequence[i] = starSequence[indexSequence];

            }

            lblSequenceReversed.Text = string.Join(",", reverseStarSequence);






            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            //use existing split starSequence:

            //I found padding (especially padright gave bad answers. so I will try something else:
            lblAsciiArt.Text = "";
            for (int i = 0; i < starSequence.Length; ++i)
            {
                double totalPadding = 14.0 - (double)starSequence[i].Length;
                int leftIndex = (int)Math.Floor(7.0 - (double)(starSequence[i].Length/ 2.0));
                int leftTrim = leftIndex;
                string startString = "**************";
                lblAsciiArt.Text += (startString.Insert(leftIndex, starSequence[i]).Remove(14) + "<br/>").Trim();

            }



            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.
            //1 take it down to lower case:
            puzzle = puzzle.ToLower();
            //now repalce z with t
            puzzle = puzzle.Replace('z', 't');
            //now dike out the 'remove-me'
            int dikeIndex = puzzle.IndexOf("remove-me");
            puzzle = puzzle.Remove(dikeIndex, "remove-me".Length);
            puzzle = puzzle.First().ToString().ToUpper()+puzzle.Substring(1);
            lblPuzzle.Text = puzzle;

        }
    }
}