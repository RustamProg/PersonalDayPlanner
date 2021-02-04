using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDayPlanner.NotesAndComments
{
    public class Note: INotifyPropertyChanged
    {
        public string title;
        public string textBody;
        public string datetime;
        public int is_done;
        public int Id { get; set; }

        public string Title
        {
            get { return title.ToUpper(); }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public string TextBody
        {
            get { return textBody; }
            set
            {
                textBody = value;
                OnPropertyChanged("TextBody");
            }
        }

        public string DateTime
        {
            get 
            {
                DateTime today = new DateTime();
                return today.ToString();
            }
            set
            {
                datetime = value;
                OnPropertyChanged("DateTime");
            }
        }

        public int Is_Done
        {
            get 
            {
                return is_done;
            }
            set
            {
                is_done = value;
                OnPropertyChanged("Is_Done");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
