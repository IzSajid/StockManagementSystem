using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSU_PMS.Models
{
    public class Category
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime DateTime { get; set; }


        

        public Category() { }

        // Private constructor used by the Builder
        private Category(Builder builder)
        {
            ID = builder.ID;
            Name = builder.Name;
            Description = builder.Description;
            Status = builder.Status;
            DateTime = builder.DateTime;
        }

        // Nested Builder class
        public class Builder
        {
            public string ID { get; private set; }
            public string Name { get; private set; }
            public string Description { get; private set; }
            public string Status { get; private set; }
            public DateTime DateTime { get; private set; }

            public Builder WithID(string id)
            {
                ID = id;
                return this;
            }

            public Builder WithName(string name)
            {
                Name = name;
                return this;
            }

            public Builder WithDescription(string description)
            {
                Description = description;
                return this;
            }

            public Builder WithStatus(string status)
            {
                Status = status;
                return this;
            }

            public Builder WithDateTime(DateTime dateTime)
            {
                DateTime = dateTime;
                return this;
            }

            public Category Build()
            {
                return new Category(this);
            }
        }

    }


}
