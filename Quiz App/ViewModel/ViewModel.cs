using System;
using System.ComponentModel;

namespace Quiz_App
{
    class ViewModel : INotifyPropertyChanged
    {
        #region Private Fields
        private string _question = "14 + 28 = ?";
        private string _answer1 = "36";
        private string _answer2 = "45";
        private string _answer3 = "43";
        private string _answer4 = "42";
        #endregion
        #region Constructor
        public ViewModel()
        {
            ButtonCommands = new ButtonCommands(this); 
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

        public ButtonCommands ButtonCommands { get; }
        public ChangeOutNewQuestionAndAnswers ChangeOutNewQuestionAndAnswers { get; }
        #endregion
        #region Question and Answer Arrays
        public static string[] Questions = new string[]
        {
            "13 + 2 = ?",
            "12 + 7 = ?",
            "34 + 12 = ?",
            "13 + 5 = ?",
            "23 + 21 = ?",
            "10 + 12 = ?",
            "45 - 12 = ?",
            "9 + 3 = ?",
            "23 - 15 = ?",
            "12 - 9 = ?",
        };
        
        public static string[] Button1AnswerChoices = new string[]
        {
            "15",
            "23",
            "46",
            "15",
            "17"
        };

        public static string[] Button2AnswerChoices = new string[]
        {
            "16",
            "12",
            "34",
            "19",
            "44",
        };

        public static string[] Button3AnswerChoices = new string[]
        {
            "14",
            "19",
            "23",
            "28",
            "46",
        };

        public static string[] Button4AnswerChoices = new string[]
        {
            "13",
            "10",
            "47",
            "18",
            "48",
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
