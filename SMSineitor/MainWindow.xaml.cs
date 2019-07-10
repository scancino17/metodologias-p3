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

namespace SMSineitor {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void Send_Click(object sender, RoutedEventArgs e) {
			var numeroInt = Convert.ToInt32(this.PhoneNumber.Text);
			var mensaje = new Mensaje(numeroInt, this.Message.Text);
			this.Exito.Text = "Enviado";
		}
		private void Emoji1_Click(object sender, RoutedEventArgs e)
        {
            string insertText = "😁";
            int selectionIndex = this.Message.SelectionStart;
            this.Message.Text = this.Message.Text.Insert(selectionIndex, insertText);
        }

        private void Emoji2_Click(object sender, RoutedEventArgs e)
        {
            string insertText = "😞";
            int selectionIndex = this.Message.SelectionStart;
            this.Message.Text = this.Message.Text.Insert(selectionIndex, insertText);
        }

        private void Emoji3_Click(object sender, RoutedEventArgs e)
        {
            string insertText = "😒";
            int selectionIndex = this.Message.SelectionStart;
            this.Message.Text = this.Message.Text.Insert(selectionIndex, insertText);
        }

        private void Emoji4_Click(object sender, RoutedEventArgs e)
        {
            string insertText = "😍";
            int selectionIndex = this.Message.SelectionStart;
            this.Message.Text = this.Message.Text.Insert(selectionIndex, insertText);
        }
        
        private void Emoji5_Click(object sender, RoutedEventArgs e)
        {
            string insertText = "😖";
            int selectionIndex = this.Message.SelectionStart;
            this.Message.Text = this.Message.Text.Insert(selectionIndex, insertText);
        }

        private void Emoji6_Click(object sender, RoutedEventArgs e)
        {
            string insertText = "😂";
            int selectionIndex = this.Message.SelectionStart;
            this.Message.Text = this.Message.Text.Insert(selectionIndex, insertText);
        }

        private void Emoji7_Click(object sender, RoutedEventArgs e)
        {
            string insertText = "😲";
            int selectionIndex = this.Message.SelectionStart;
            this.Message.Text = this.Message.Text.Insert(selectionIndex, insertText);
        }

        private void Emoji8_Click(object sender, RoutedEventArgs e)
        {
            string insertText = "😨";
            int selectionIndex = this.Message.SelectionStart;
            this.Message.Text = this.Message.Text.Insert(selectionIndex, insertText);
        }

        private void Emoji9_Click(object sender, RoutedEventArgs e)
        {
            string insertText = "😚";
            int selectionIndex = this.Message.SelectionStart;
            this.Message.Text = this.Message.Text.Insert(selectionIndex, insertText);
        }

        private void Emoji10_Click(object sender, RoutedEventArgs e)
        {
            string insertText = "😡";
            int selectionIndex = this.Message.SelectionStart;
            this.Message.Text = this.Message.Text.Insert(selectionIndex, insertText);
        }
	}
}
