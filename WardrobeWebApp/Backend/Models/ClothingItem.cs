﻿using Backend.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Backend.Models
{
    public class ClothingItem
    {

        public int Id { get; set; }
        public int UserId { get; set; }

        public int ImageId { get; set; }
        public string Name { get; set; }
        [EnumDataType(typeof(ClothingCategory))]
        public ClothingCategory Category { get; set; }
        [EnumDataType(typeof(ClothingSize))]
        public ClothingSize Size { get; set; }

        public string Brand { get; set; }
        //public List<Colour> Colours { get; set; }
        //public Color Colour { get; set; }
        public string Colour { get; set; }
        [EnumDataType(typeof(Occasion))]
        public Occasion Occasion { get; set; }
        [EnumDataType(typeof(Season))]
        public Season Season { get; set; }

        public ClothingItem UpdateWithValuesFrom(ClothingItem other)
        {
            this.UserId = other.UserId;
            this.ImageId = other.ImageId;
            this.Name = other.Name;
            this.Category = other.Category;
            this.Size = other.Size;
            this.Brand = other.Brand;
            this.Colour = other.Colour;
            this.Occasion = other.Occasion;
            this.Season = other.Season;

            return this;
        }

        public bool HasSameValuesAs(ClothingItem other)
        {
            return  this.UserId == other.UserId &&
                    this.ImageId == other.ImageId &&
                    this.Name == other.Name &&
                    this.Category == other.Category &&
                    this.Size == other.Size &&
                    this.Brand == other.Brand &&
                    this.Colour == other.Colour &&
                    this.Occasion == other.Occasion &&
                    this.Season == other.Season;
        }
    }
}
