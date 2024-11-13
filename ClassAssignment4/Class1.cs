using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment4
{
    internal class flower

    {
        // Private member variables
        private string type;
        private string flowerName;
        private string flowerColor;
        private string season;
        private string input1;
        private string input2;
        private string input3;

        // Constructor to initialize the flower's properties
        public flower(string type, string flowerName, string flowerColor, string season)
        {
            this.type = type;
            this.flowerName = flowerName;
            this.flowerColor = flowerColor;
            this.season = season;
        }

        public flower(string type, string flowerName, string flowerColor)
        {
            this.input1 = type;
            this.input1= flowerName;
            this.input3 = flowerColor;
        }

        // Private method to describe the flower type
        private string GetFlowerType()
        {
            return $"Flower Type: {type}";
        }

        // Private method to describe the flower
        private string DescribeFlower()
        {
            return $"Flower: {flowerName}, Color: {flowerColor}, Season: {season}";
        }

        // Public method to display flower details
        public void DisplayFlowerInfo()
        {
            Console.WriteLine(GetFlowerType());
            Console.WriteLine(DescribeFlower());
        }

        // Public method to simulate blooming
        public void Bloom()
        {
            Console.WriteLine($"The {type} is blooming with {flowerColor} {flowerName}s in {season}.");
        }   
    }   
}