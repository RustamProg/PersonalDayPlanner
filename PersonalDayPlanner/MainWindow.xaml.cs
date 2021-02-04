using PersonalDayPlanner.NotesAndComments;
using PersonalDayPlanner.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonalDayPlanner
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.notes.Load();
            this.DataContext = db.notes.Local.ToBindingList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NotesAddWindow noteWindow = new NotesAddWindow(new Note());
            if (noteWindow.ShowDialog() == true)
            {
                Note note = noteWindow.Note;
                db.notes.Add(note);
                db.SaveChanges();
            }
        }
    }
}
