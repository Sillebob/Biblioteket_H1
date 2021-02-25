using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteket_H1
{
    class Book
    {
        // Make a class to represent a book with the appropriate properties

        // Declaring variables for the properties
        private int id;
        private string title;
        private string forfatter_fornavn;
        private string forfatter_efternavn;
        private int udgivelsesår;
        private int sideantal;

        // Defining Set&get conditions
        public int Id { get { return id; } set { id = value; } }
        public string Title { get { return title; } set { title = value; } }
        public string Forfatter_fornavn { get { return forfatter_fornavn; } set { forfatter_fornavn = value; } }
        public string Forfatter_efternavn { get { return forfatter_efternavn; } set { forfatter_efternavn = value; } }
        public int Udgivelsesår { get { return udgivelsesår; } set {  udgivelsesår = value; } }
        public int Sideantal { get { return sideantal; } set { sideantal = value; } }

        // Making a constructor with the chosen properties
        public Book(int id, string title, string forfatter_efternavn, string forfatter_fornavn, int udgivelsesår, int sideantal)
        {
            this.id = id;
            this.title = title;
            this.forfatter_efternavn = forfatter_efternavn;
            this.forfatter_fornavn = forfatter_fornavn;
            this.udgivelsesår = udgivelsesår;
            this.sideantal = sideantal;
        }

    }
}
