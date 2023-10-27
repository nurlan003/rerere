using LibraryProject.Data.Repositories.Concretes;
using LibraryProject.Models.Entities.Concretes;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Repository<Category> repository = new Repository<Category>();
            Category category = new Category();
            for (int i = 0; i < 20; i++)
            {
                category.Name = "Added Category";
                category.ModefiedDate = DateTime.Now;
                repository.Update(category);
                repository.SaveChange();

            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Repository<Author> repository = new Repository<Author>();
            Author author = new Author();

            author.FirstName = "Nurlan";
            author.LastName = "Nurlan";
            author.ModefiedDate = DateTime.Now;
            repository.Update(author);
            repository.SaveChange();


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Repository<Department> repository = new Repository<Department>();
            Department author = new Department();
            author.Name = "Dp1";
            author.ModefiedDate = DateTime.Now;
            repository.Update(author);
            repository.SaveChange();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Repository<Faculty> repository = new Repository<Faculty>();
            Faculty faculty = new Faculty();
            faculty.Name = "Fc1";
            faculty.ModefiedDate = DateTime.Now;
            repository.Update(faculty);
            repository.SaveChange();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Repository<Groupp> repository = new Repository<Groupp>();
            Groupp groupp = new Groupp();
            groupp.Name = "Gr1";
            groupp.FacultyId = 1;
            groupp.ModefiedDate = DateTime.Now;
            repository.Update(groupp);
            repository.SaveChange();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Repository<Lib> repository = new Repository<Lib>();
            Lib lib = new Lib();
            lib.FirstName = "LiF";
            lib.LastName = "LiL";
            lib.ModefiedDate = DateTime.Now;
            repository.Update(lib);
            repository.SaveChange();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Repository<Press> repository = new Repository<Press>();
            Press press = new Press();
            press.Name = "pr1";
            press.ModefiedDate = DateTime.Now;
            repository.Update(press);
            repository.SaveChange();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Repository<Student> repository = new Repository<Student>();
            Student student = new Student();
            student.FirstName = "st1";
            student.LastName = "st11";
            student.term = 1;
            student.GroupId = 1;
            student.ModefiedDate = DateTime.Now;
            repository.Update(student);
            repository.SaveChange();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Repository<Teacher> repository = new Repository<Teacher>();
            Teacher teacher = new Teacher();
            teacher.FirstName = "tc1";
            teacher.LastName = "tc11";
            teacher.ModefiedDate = DateTime.Now;
            repository.Update(teacher);
            repository.SaveChange();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Repository<Theme> repository = new Repository<Theme>();
            Theme theme = new Theme();
            theme.Name = "tc1";
            theme.ModefiedDate = DateTime.Now;
            repository.Update(theme);
            repository.SaveChange();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Repository<Book> repository = new Repository<Book>();
            Book book = new Book();
            book.Name = "tc1";
            book.YearPress = 2000;
            book.PressId = 1;
            book.Comment = "sdsd";
            book.AuthorId = 1;
            book.CategoryId = 1;
            book.Pages = 1;
            book.Quantity = 1;  
            book.ModefiedDate = DateTime.Now;
            repository.Update(book);
            repository.SaveChange();
        }
    }
}
