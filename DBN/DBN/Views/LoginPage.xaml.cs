﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBN.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DBN.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            Init();

            void Init()
            {
                //Entry Username.Completed += (s, e) => Entry.Password.Focus();
                
            }
        
		}

        void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "Ok");
            }
            else
            {
                DisplayAlert("Login", "Please enter a Username and Password", "Ok");
            }
        }
	}
}