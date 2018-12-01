using System;
using System.ComponentModel;

namespace Quiz_App
{
    class ViewModel : INotifyPropertyChanged
    {
        #region Private Fields
        private string _question;
        private string _answer1;
        private string _answer2;
        private string _answer3;
        private string _answer4;
        #endregion
        #region Constructor
        public ViewModel()
        {

        }
        #endregion
        #region Public Properties
        public string Question
        {
            get => this._question;
            set
            {
                if(this._question != value)
                {
                    this._question = value;
                    OnPropertyChanged("Question");
                }
            }
        }

        public string Answer1
        {
            get => this._answer1;
            set
            {
                if(this._answer1 != value)
                {
                    this._answer1 = value;
                    OnPropertyChanged("Answer1");
                }
            
}
        }

        public string Answer2
        {
            get => this._answer2;
            set
            {
                if(this._answer2 != value)
                {
                    this._answer2 = value;
                    OnPropertyChanged("Answer2");
                }
            }
        }

        public string Answer3
        {
            get => this._answer3;
            set
            {
                if(this._answer3 != value)
                {
                    this._answer3 = value;
                    OnPropertyChanged("Answer3");
                }
            }
        }

        public string Answer4
        {
            get => this._answer4;
            set
            {
                if(this._answer4 != value)
                {
                    this._answer4 = value;
                    OnPropertyChanged("Answer4");
                }
            }
        }
        #endregion
        #region Question and Answer Arrays
        string[] Questions = new string[]
        {
            "13 + 2 = ?",
            "12 + 7 = ?",
        };
        
        string[] Button1AnswerChoices = new string[]
        {
            "15",
            "23",
        };

        string[] Button2AnswerChoices = new string[]
        {
            "16",
            "12",
        };

        string[] Button3AnswerChoices = new string[]
        {
            "14",
            "19",
        };

        string[] Button4AnswerChoices = new string[]
        {
            "13",
            "10",
        };
        #endregion
        #region INotifyPropertyChanged Definition
        /// <summary>
        /// if property is changed, invoke new property changed event
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
