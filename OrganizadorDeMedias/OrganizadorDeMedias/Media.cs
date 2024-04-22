using System;
namespace OrganizadorDeMedias
{
    internal class Media
    {
        string color;
        public Media(string color)
        {
            this.color = color;
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
    }
}

