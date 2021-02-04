using PersonalDayPlanner.NotesAndComments;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace PersonalDayPlanner.Windows
{
    /// <summary>
    /// Логика взаимодействия для NotesList.xaml
    /// </summary>
    public partial class NotesAddWindow : Window
    {
        public Note Note { get; private set; }
        
        public NotesAddWindow(Note n)
        {
            InitializeComponent();
            Note = n;
            this.DataContext = Note;           
        }
        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
