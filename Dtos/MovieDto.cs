﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Flixster.Dtos
{
    public class MovieDto
    {
        public MovieDto()
        {
            DateAdded = DateTime.Now;
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        public GenreDto Genre { get; set; }

        [Required]
        public int GenreId { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}