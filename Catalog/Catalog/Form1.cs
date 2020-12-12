using Catalog.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Catalog
{
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();
        List<Record> records = new List<Record>();
        List<Movie> movies = new List<Movie>();
        BindingList<Item> selectedItems = new BindingList<Item>();


        public Form1()
        {
            InitializeComponent();


            dataGridView2.DataSource = selectedItems;

        }

        public void ImportXML(string catalog)
        {
            var xml = new XmlDocument();

            if (catalog == "Books")
            {
                xml.Load("C:/Users/Dell/source/repos/IRF_Project/Catalog/Catalog/bin/Debug/books.xml");
                foreach (XmlElement element in xml.DocumentElement)
                {
                    var book = new Book();
                    books.Add(book);

                    book.Creator = element.ChildNodes[0].InnerText;
                    book.Title = element.ChildNodes[1].InnerText;
                    book.Genre = element.ChildNodes[2].InnerText;
                    book.Length = Int32.Parse(element.ChildNodes[3].InnerText);
                    book.PublishDate = DateTime.Parse(element.ChildNodes[4].InnerText);
                }

                dataGridView1.DataSource = books;

                dataGridView1.Columns["Creator"].DisplayIndex = 0;
                dataGridView1.Columns["Title"].DisplayIndex = 1;
                dataGridView1.Columns["Genre"].DisplayIndex = 2;
                dataGridView1.Columns["Length"].DisplayIndex = 3;
                dataGridView1.Columns["PublishDate"].DisplayIndex = 4;

                dataGridView1.Columns["Creator"].HeaderText = "Author";
                dataGridView1.Columns["Length"].HeaderText = "Length (pages)";

               
            }
            else if (catalog == "Records")
            {
                xml.Load("C:/Users/Dell/source/repos/IRF_Project/Catalog/Catalog/bin/Debug/records.xml");
                foreach (XmlElement element in xml.DocumentElement)
                {
                    var record = new Record();
                    records.Add(record);

                    record.Creator = element.ChildNodes[0].InnerText;
                    record.Title = element.ChildNodes[1].InnerText;
                    record.Genre = element.ChildNodes[2].InnerText;
                    record.LengthMins = Int32.Parse(element.ChildNodes[3].InnerText);
                    record.NumberOfSongs = Int32.Parse(element.ChildNodes[4].InnerText);
                }

                dataGridView1.DataSource = records;
                dataGridView1.Columns["Creator"].DisplayIndex = 0;
                dataGridView1.Columns["Title"].DisplayIndex = 1;
                dataGridView1.Columns["Genre"].DisplayIndex = 2;
                dataGridView1.Columns["LengthMins"].DisplayIndex = 3;
                dataGridView1.Columns["NumberOfSongs"].DisplayIndex = 4;
                dataGridView1.Columns["Creator"].HeaderText = "Artist";
                dataGridView1.Columns["LengthMins"].HeaderText = "Length (minutes)";
            }
            else if (catalog == "Movies")
            {
                xml.Load("C:/Users/Dell/source/repos/IRF_Project/Catalog/Catalog/bin/Debug/films.xml");
                foreach (XmlElement element in xml.DocumentElement)
                {
                    var movie = new Movie();
                    movies.Add(movie);

                    movie.Creator = element.ChildNodes[0].InnerText;
                    movie.Title = element.ChildNodes[1].InnerText;
                    movie.Genre = element.ChildNodes[2].InnerText;
                    movie.LengthHours = Int32.Parse(element.ChildNodes[3].InnerText);
                    movie.Languages = element.ChildNodes[4].InnerText;
                    movie.ReleaseDate = DateTime.Parse(element.ChildNodes[5].InnerText);
                }

                dataGridView1.DataSource = movies;
                dataGridView1.Columns["Creator"].DisplayIndex = 0;
                dataGridView1.Columns["Title"].DisplayIndex = 1;
                dataGridView1.Columns["Genre"].DisplayIndex = 2;
                dataGridView1.Columns["LengthHours"].DisplayIndex = 3;
                dataGridView1.Columns["Languages"].DisplayIndex = 5;
                dataGridView1.Columns["ReleaseDate"].DisplayIndex = 4;
                dataGridView1.Columns["Creator"].HeaderText = "Director";
                dataGridView1.Columns["LengthHours"].HeaderText = "Length (hours)";

            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImportXML(comboBox1.Text);
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Movies")
            {
                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    var item = new Item();
                    item.Creator = r.Cells[3].Value.ToString();
                    item.Title = r.Cells[4].Value.ToString();
                    item.Genre = r.Cells[5].Value.ToString();

                    selectedItems.Add(item);
                }

            }
            else
            {
                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    var item = new Item();
                    item.Creator = r.Cells[2].Value.ToString();
                    item.Title = r.Cells[3].Value.ToString();
                    item.Genre = r.Cells[4].Value.ToString();

                    selectedItems.Add(item);
                }
            }


        }
    }
}
