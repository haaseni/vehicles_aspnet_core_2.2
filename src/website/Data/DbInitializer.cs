using System;
using System.Collections.Generic;
using System.Linq;
using website.Entities;

namespace website.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TestContext context)
        {
            if (context.Vehicles.Any())
            {
                return; // DB has been seeded
            }

            var makes = new Make[]
            {
                new Make { Name = "Toyota" },
                new Make { Name = "Honda" },
                new Make { Name = "Hyundai" },
                new Make { Name = "Ford" },
                new Make { Name = "Chevrolet" },
            };

            foreach (var make in makes)
            {
                context.Makes.Add(make);
            }

            context.SaveChanges();

            var models = new List<Model>();
            var toyota = context.Makes.FirstOrDefault(m => m.Name == "Toyota");
            var honda = context.Makes.FirstOrDefault(m => m.Name == "Honda");
            var hyundai = context.Makes.FirstOrDefault(m => m.Name == "Hyundai");
            var ford = context.Makes.FirstOrDefault(m => m.Name == "Ford");
            var chevrolet = context.Makes.FirstOrDefault(m => m.Name == "Chevrolet");

            models.Add(new Model { MakeId = toyota.MakeId, Name = "Highlander" });
            models.Add(new Model { MakeId = toyota.MakeId, Name = "4Runner" });
            models.Add(new Model { MakeId = toyota.MakeId, Name = "Rav4" });
            models.Add(new Model { MakeId = toyota.MakeId, Name = "Corolla" });
            models.Add(new Model { MakeId = toyota.MakeId, Name = "Camry" });
            
            models.Add(new Model { MakeId = honda.MakeId, Name = "Pilot" });
            models.Add(new Model { MakeId = honda.MakeId, Name = "Passport" });
            models.Add(new Model { MakeId = honda.MakeId, Name = "CR-V" });
            models.Add(new Model { MakeId = honda.MakeId, Name = "Accord" });
            models.Add(new Model { MakeId = honda.MakeId, Name = "Civic" });
            
            models.Add(new Model { MakeId = hyundai.MakeId, Name = "Santa Fe" });
            models.Add(new Model { MakeId = hyundai.MakeId, Name = "Sonata" });
            models.Add(new Model { MakeId = hyundai.MakeId, Name = "Accent" });
            
            models.Add(new Model { MakeId = ford.MakeId, Name = "Edge" });
            models.Add(new Model { MakeId = ford.MakeId, Name = "Mustang" });
            models.Add(new Model { MakeId = ford.MakeId, Name = "Fusion" });
            models.Add(new Model { MakeId = ford.MakeId, Name = "F-150" });
            models.Add(new Model { MakeId = ford.MakeId, Name = "F-250" });
            models.Add(new Model { MakeId = ford.MakeId, Name = "F-350" });
            
            models.Add(new Model { MakeId = chevrolet.MakeId, Name = "Equinox" });
            models.Add(new Model { MakeId = chevrolet.MakeId, Name = "Camaro" });
            models.Add(new Model { MakeId = chevrolet.MakeId, Name = "Impala" });
            models.Add(new Model { MakeId = chevrolet.MakeId, Name = "Cruze" });
            models.Add(new Model { MakeId = chevrolet.MakeId, Name = "Cavalier" });

            foreach (var model in models)
            {
                context.Models.Add(model);
            }

            context.SaveChanges();

            var highlander = context.Models.FirstOrDefault(m => m.Name == "Highlander");
            var _4Runner = context.Models.FirstOrDefault(m => m.Name == "4Runner");
            var rav4 = context.Models.FirstOrDefault(m => m.Name == "Rav4");
            var corolla = context.Models.FirstOrDefault(m => m.Name == "Corolla");
            var camry = context.Models.FirstOrDefault(m => m.Name == "Camry");
            var pilot = context.Models.FirstOrDefault(m => m.Name == "Pilot");
            var passport = context.Models.FirstOrDefault(m => m.Name == "Passport");
            var crv = context.Models.FirstOrDefault(m => m.Name == "CR-V");
            var accord = context.Models.FirstOrDefault(m => m.Name == "Accord");
            var civic = context.Models.FirstOrDefault(m => m.Name == "Civic");
            var santaFe = context.Models.FirstOrDefault(m => m.Name == "Santa Fe");
            var sonata = context.Models.FirstOrDefault(m => m.Name == "Sonata");
            var accent = context.Models.FirstOrDefault(m => m.Name == "Accent");
            var edge = context.Models.FirstOrDefault(m => m.Name == "Edge");
            var mustang = context.Models.FirstOrDefault(m => m.Name == "Mustang");
            var fusion = context.Models.FirstOrDefault(m => m.Name == "Fusion");
            var f150 = context.Models.FirstOrDefault(m => m.Name == "F-150");
            var f250 = context.Models.FirstOrDefault(m => m.Name == "F-250");
            var f350 = context.Models.FirstOrDefault(m => m.Name == "F-350");
            var equinox = context.Models.FirstOrDefault(m => m.Name == "Equinox");
            var camaro = context.Models.FirstOrDefault(m => m.Name == "Camaro");
            var impala = context.Models.FirstOrDefault(m => m.Name == "Impala");
            var cruze = context.Models.FirstOrDefault(m => m.Name == "Cruze");
            var cavalier = context.Models.FirstOrDefault(m => m.Name == "Cavalier");

            for(var i = 1997; i < (DateTime.Now.Year + 1); i++)
            {
                highlander.Years.Add(new ModelYear { ModelId = highlander.ModelId, Year = i });
            }
            for (var i = 1989; i < (DateTime.Now.Year + 1); i++)
            {
                _4Runner.Years.Add(new ModelYear { ModelId = _4Runner.ModelId, Year = i });
            }
            for (var i = 1993; i < (DateTime.Now.Year + 1); i++)
            {
                rav4.Years.Add(new ModelYear { ModelId = rav4.ModelId, Year = i });
            }
            for (var i = 1985; i < (DateTime.Now.Year + 1); i++)
            {
                corolla.Years.Add(new ModelYear { ModelId = corolla.ModelId, Year = i });
            }
            for (var i = 1983; i < (DateTime.Now.Year + 1); i++)
            {
                camry.Years.Add(new ModelYear { ModelId = camry.ModelId, Year = i });
            }

            for (var i = 2002; i < (DateTime.Now.Year + 1); i++)
            {
                pilot.Years.Add(new ModelYear { ModelId = pilot.ModelId, Year = i });
            }
            for (var i = 1990; i < (DateTime.Now.Year + 1); i++)
            {
                passport.Years.Add(new ModelYear { ModelId = passport.ModelId, Year = i });
            }
            for (var i = 1988; i < (DateTime.Now.Year + 1); i++)
            {
                crv.Years.Add(new ModelYear { ModelId = crv.ModelId, Year = i });
            }
            for (var i = 1981; i < (DateTime.Now.Year + 1); i++)
            {
                accord.Years.Add(new ModelYear { ModelId = accord.ModelId, Year = i });
            }
            for (var i = 1975; i < (DateTime.Now.Year + 1); i++)
            {
                civic.Years.Add(new ModelYear { ModelId = civic.ModelId, Year = i });
            }

            for (var i = 2004; i < (DateTime.Now.Year + 1); i++)
            {
                santaFe.Years.Add(new ModelYear { ModelId = santaFe.ModelId, Year = i });
            }
            for (var i = 2004; i < (DateTime.Now.Year + 1); i++)
            {
                sonata.Years.Add(new ModelYear { ModelId = sonata.ModelId, Year = i });
            }
            for (var i = 1985; i < (DateTime.Now.Year + 1); i++)
            {
                accent.Years.Add(new ModelYear { ModelId = accent.ModelId, Year = i });
            }

            for (var i = 2003; i < (DateTime.Now.Year + 1); i++)
            {
                edge.Years.Add(new ModelYear { ModelId = edge.ModelId, Year = i });
            }
            for (var i = 1964; i < (DateTime.Now.Year + 1); i++)
            {
                mustang.Years.Add(new ModelYear { ModelId = mustang.ModelId, Year = i });
            }
            for (var i = 2003; i < (DateTime.Now.Year + 1); i++)
            {
                fusion.Years.Add(new ModelYear { ModelId = fusion.ModelId, Year = i });
            }
            for (var i = 1972; i < (DateTime.Now.Year + 1); i++)
            {
                f150.Years.Add(new ModelYear { ModelId = f150.ModelId, Year = i });
            }
            for (var i = 1983; i < (DateTime.Now.Year + 1); i++)
            {
                f250.Years.Add(new ModelYear { ModelId = f250.ModelId, Year = i });
            }
            for (var i = 1987; i < (DateTime.Now.Year + 1); i++)
            {
                f350.Years.Add(new ModelYear { ModelId = f350.ModelId, Year = i });
            }

            for (var i = 2002; i < (DateTime.Now.Year + 1); i++)
            {
                equinox.Years.Add(new ModelYear { ModelId = equinox.ModelId, Year = i });
            }
            for (var i = 1967; i < (DateTime.Now.Year + 1); i++)
            {
                camaro.Years.Add(new ModelYear { ModelId = camaro.ModelId, Year = i });
            }
            for (var i = 1965; i < (DateTime.Now.Year + 1); i++)
            {
                impala.Years.Add(new ModelYear { ModelId = impala.ModelId, Year = i });
            }
            for (var i = 2004; i < (DateTime.Now.Year + 1); i++)
            {
                cruze.Years.Add(new ModelYear { ModelId = cruze.ModelId, Year = i });
            }
            for (var i = 1986; i < (DateTime.Now.Year + 1); i++)
            {
                cavalier.Years.Add(new ModelYear { ModelId = cavalier.ModelId, Year = i });
            }

            context.SaveChanges();

            var vehicles = new[]
            {
                new Vehicle { ModelId = context.Models.FirstOrDefault(m => m.Name == "Highlander").ModelId, Year = 1997 },
                new Vehicle { ModelId = context.Models.FirstOrDefault(m => m.Name == "Pilot").ModelId, Year = 2005 },
                new Vehicle { ModelId = context.Models.FirstOrDefault(m => m.Name == "Santa Fe").ModelId, Year = 2018 },
                new Vehicle { ModelId = context.Models.FirstOrDefault(m => m.Name == "Edge").ModelId, Year = 2002 },
                new Vehicle { ModelId = context.Models.FirstOrDefault(m => m.Name == "Equinox").ModelId, Year = 2013 }
            };

            foreach (var vehicle in vehicles)
            {
                context.Vehicles.Add(vehicle);
            }

            context.SaveChanges();
        }
    }
}
