﻿using System;
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
	}
}
