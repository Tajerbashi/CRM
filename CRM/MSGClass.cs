using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public class MSGClass
    {

        public DialogResult ShowMSGBoxDialog(String title,String Fa,String En,int type,int Status)
        {
            MSGBoxForm MSG = new MSGBoxForm();
            
            
            MSG.TitleLbl.Text=title;
            MSG.InfoFALBL.Text=Fa;
            MSG.InfoLblEN.Text=En;
            MSG.PIC.Visible = true;
            if (type==1)
            {   
                //  OK
                //  1   information , Message
                MSG.OKBtn.Visible = true;
                if (Status==1)
                {   //  information 
                    MSG.BluePanel.Style.BackColor1.Color = Color.FromArgb(28, 56, 121);
                    MSG.BluePanel.Style.BackColor2.Color = Color.FromArgb(88, 0, 255);
                    MSG.PIC.Image = Properties.Resources.Information1;
                }
                else
                {   //  message 
                    MSG.BluePanel.Style.BackColor1.Color = Color.FromArgb(28, 56, 121);
                    MSG.BluePanel.Style.BackColor2.Color = Color.FromArgb(88, 0, 255);
                    MSG.PIC.Image = Properties.Resources.message1;
                }
            }
            else if (type == 2)
            {
                //    YESNO();
                //  2   Question , Delete
                MSG.YESBtn.Visible = true;
                MSG.NOBtn.Visible = true;
                if (Status==1)
                {   
                    //  Delete
                    MSG.BluePanel.Style.BackColor1.Color = Color.FromArgb(192, 0, 0);
                    MSG.BluePanel.Style.BackColor2.Color = Color.FromArgb(190, 100, 14);
                    MSG.PIC.Image = Properties.Resources.Delete1;
                }
                else
                {
                    //  Question
                    MSG.BluePanel.Style.BackColor1.Color = Color.FromArgb(28, 56, 121);
                    MSG.BluePanel.Style.BackColor2.Color = Color.FromArgb(88, 0, 255);
                    MSG.PIC.Image = Properties.Resources.Question1;
                }
                
            }
            else if (type == 3)
            {
                //    OK();
                //  3   Error , Warning
                MSG.OKBtn.Visible = true;
                if (Status == 0)
                {
                    //  Error
                    MSG.BluePanel.Style.BackColor1.Color = Color.FromArgb(192, 0, 0);
                    MSG.BluePanel.Style.BackColor2.Color = Color.FromArgb(190, 100, 14);
                    MSG.PIC.Image = Properties.Resources.Error1;
                }
                else
                {
                    //  Warning
                    MSG.BluePanel.Style.BackColor1.Color = Color.FromArgb(192, 0, 0);
                    MSG.BluePanel.Style.BackColor2.Color = Color.FromArgb(190, 100, 14);
                    MSG.PIC.Image = Properties.Resources.Warning1;
                }
            }
            else
            {   //  4   Exit
                MSG.ExitBtn.Visible = true;
                MSG.BackBtn.Visible = true;
                MSG.BluePanel.Style.BackColor1.Color = Color.FromArgb(192, 0, 0);
                MSG.BluePanel.Style.BackColor2.Color = Color.FromArgb(190, 100, 14);
                MSG.PIC.Image = Properties.Resources.Exit1;
            }

            MSG.ShowDialog();
            return MSG.DialogResult;
        }
    }
}
