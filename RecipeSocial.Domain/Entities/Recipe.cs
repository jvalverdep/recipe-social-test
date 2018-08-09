﻿using RecipeSocial.Domain.Entities.Template;
using System.Collections.Generic;

namespace RecipeSocial.Domain.Entities
{
    public class Recipe : Base
    {
        public string Name { get; set; }
        public int TotalLikes { get; set; }
        public int Views { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<Preparation> Preparations { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }

        public ICollection<RecipeTag> RecipeTags { get; set; }
    }
}
