using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using TestWPF.Model;
using TestWPF.View;
using TestWPF.Helper;
using TestWPF.Navigation;

namespace TestWPF.ViewModel
{
    public class SignInViewModel : BaseViewModel
    {
        private SignInModel signInModel = new SignInModel();

        #region Properties

        private string loginText;
        public string LoginText { 
            get => loginText; 
            set
            {
                loginText = value;
                OnPropertyChanged(nameof(LoginText));
            }
        }
        private string passwordText;
        public string PasswordText
        {
            get => passwordText;
            set
            {
                passwordText = value;
                OnPropertyChanged(nameof(PasswordText));
            }
        }

        #endregion

        #region Methods

        public bool IsAccountCorrect()
        {
            var User = signInModel.GetUserFromDB(LoginText, PasswordText);
            return User != null;
        }

        #endregion

        #region Commands

        private ICommand signIn;
        public ICommand SignIn
        {
            get
            {
                return signIn ??
                    (signIn = new ActionCommand(() =>
                    {
                        if (IsAccountCorrect())
                        {
                            Navigator.Navigate(Navigator.PageAlias.MainMenu);
                        }
                        else
                        {
                            MessageBox.Show("Не удаётся найти пользователя с указанным именем или паролем.");
                        }
                    }));
            }
        }

        #endregion
    }
}
