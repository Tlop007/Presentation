// Microsoft
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

// Client
using Client.Knihovny;
using Client.Knihovny.Rozdeleni;

namespace Client.Okna.GUI
{
    /// <summary>
    /// Interaction logic for GUI_Denik.xaml
    /// </summary>
    public partial class GUI_Denik : UserControl
    {
        //Private - Knihovna_InfoAplikace:
        private Knihovna_InfoAplikace knihovnaInfoAplikace;

        //Private - Bool:
        private bool kontrolaMenuOtevreni { get; set; }

        //======================================================================================
        //=================================Hlavní Funkcionalita=================================
        //Public - Konstruktor:
        public GUI_Denik()
        {
            InitializeComponent();
            Funkce_VedlejsiNastaveni();
        }

        //Private - Void:
        private void Image_Menu_MouseEnter(object sender, MouseEventArgs e)
        {
            Funkce_AnimaceMenuMouse(sender, 1f, 1.15f, true);
        }

        private void Image_Menu_MouseLeave(object sender, MouseEventArgs e)
        {
            Funkce_AnimaceMenuMouse(sender, 1.15f, 1f, false);
        }

        private void Image_Menu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Funkce_AnimaceMenuClick();
        }

        private void RichTextBox_Denik_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (kontrolaMenuOtevreni)
                Funkce_AnimaceMenuClick();
        }

        //======================================================================================
        //================================Vedlejší Funkcionalita================================
        //Private - String:
        private string Text_OpravaNazvuDeniku(string HodnotaString)
        {
            if (HodnotaString.IndexOf('/') > 0)
                return Text_OpravaNazvuDeniku(HodnotaString.Substring(0, HodnotaString.IndexOf('/')), 18);
            else
                return Text_OpravaNazvuDeniku(HodnotaString, 18);
        }

        private string Text_OpravaNazvuDeniku(string HodnotaString, byte HodnotaByte)
        {
            if (HodnotaString.Count() <= HodnotaByte)
                return HodnotaString;
            else
                return string.Format("{0}...", HodnotaString.Substring(0, HodnotaByte));
        }

        //Private - Void:
        private void Funkce_VedlejsiNastaveni()
        {
            knihovnaInfoAplikace = new Knihovna_InfoAplikace();

            Funkce_PrideleniDeniku();
        }

        private void Funkce_AnimaceMenuMouse(object sender, float fromValue, float toValue, bool HodnotaBool)
        {
            ScaleTransform scaleTransform = new ScaleTransform();

            Image image = (Image)sender;
            image.RenderTransform = (Transform)scaleTransform;
            image.RenderTransformOrigin = new Point(0.5, 0.5);

            DoubleAnimation doubleAnimation = new DoubleAnimation(fromValue, toValue, new Duration(TimeSpan.FromSeconds(0.1)));
            if (HodnotaBool)
                doubleAnimation.FillBehavior = FillBehavior.HoldEnd;
            else
                doubleAnimation.FillBehavior = FillBehavior.Stop;

            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, (AnimationTimeline)doubleAnimation);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, (AnimationTimeline)doubleAnimation);
        }

        private void Funkce_AnimaceMenuClick()
        {
            Storyboard storyBoard_DockPanel;
            Storyboard storyBoard_RichTextBox;

            if (!kontrolaMenuOtevreni)
            {
                storyBoard_DockPanel = Resources["ShowMenu"] as Storyboard;
                storyBoard_RichTextBox = Resources["StartBlur"] as Storyboard;

                RichTextBox_Denik.Cursor = Cursors.Arrow;
                RichTextBox_Denik.IsReadOnly = true;
            }
            else
            {
                storyBoard_DockPanel = Resources["HideMenu"] as Storyboard;
                storyBoard_RichTextBox = Resources["EndBlur"] as Storyboard;

                RichTextBox_Denik.Cursor = null;
                RichTextBox_Denik.IsReadOnly = false;
            }

            storyBoard_DockPanel.Begin(DockPanel_Menu);
            storyBoard_RichTextBox.Begin(RichTextBox_Denik);
            kontrolaMenuOtevreni = !kontrolaMenuOtevreni;
        }

        private void Funkce_PrideleniDeniku()
        {
            for (int i = 0; i < knihovnaInfoAplikace.GetSet_Deniky.Count; i++)
            {
                TreeViewItem item = new TreeViewItem();

                item.Tag = knihovnaInfoAplikace.GetSet_Deniky[i].IDDenik;
                string textValue = knihovnaInfoAplikace.GetSet_Deniky[i].Text;

                //item.Content = Text_OpravaNazvuDeniku(textValue);
                //item.


                treeView1.Items.Add(knihovnaInfoAplikace.GetSet_Deniky[i].Date);
                //listView_Menu.Items.Add(item);
            }
        }

        private void Image_Menu_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
    }
}
