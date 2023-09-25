namespace Biblioteca_Recetas.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Bandera { get; set; }
        public List<Receta> Recetas { get; set; } = new List<Receta>();
    }

    public class Receta
    {
        public string? Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Imagen { get; set; }
        public int PaisId { get; set; }
        public virtual Pais? Pais { get; set; }
    }

    public static class Datos
    {
        public static IEnumerable<Pais> ObtenerPaisesConRecetas()
        {
            return paises;
        }

        public static void CrearPais(Pais pais)
        {
            paises.Add(pais);
        }

        public static void CrearReceta(Receta receta)
        {
            var pais = paises.FirstOrDefault(x => x.Id == receta.PaisId);
            pais?.Recetas.Add(receta);
        }
        private static readonly List<Pais> paises = new()
        {
            new Pais
                {
                    Id = 1,
                    Nombre = "República Dominicana",
                    Bandera = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Flag_of_the_Dominican_Republic.svg/1200px-Flag_of_the_Dominican_Republic.svg.png",
                    Recetas = new List<Receta>
                    {
                        new Receta
                        {
                            Id = "1",
                            Nombre = "Mangú",
                            Descripcion = "Plato hecho a base de plátano verde, con cebolla frita, queso frito y salami frito.",
                            Imagen = "https://upload.wikimedia.org/wikipedia/commons/b/be/Mangu_dominicano_--Contenido-_-Lonjas_de_salami_fritas_-Lonjas_de_queso_blanco_-Mangu_o_pur%C3%A9_de_pl%C3%A1tano_verde_-Mantequilla_--Este_es_un_plato_t%C3%ADpico_en_el_desayuno_dominicano_--Rep%C3%BAblica_Dominicana_-_2013-10-08_14-28.jpg",
                            PaisId = 1,
                        },
                        new Receta
                        {
                            Id = "2",
                            Nombre = "Sancocho",
                            Descripcion = "Guiso con carne, víveres y vegetales que varían según la región y la preferencia de quien lo cocina.",
                            Imagen = "https://cdn0.recetasgratis.net/es/posts/1/7/6/sancocho_dominicano_15671_orig.jpg",
                            PaisId = 1,
                        },
                        new Receta
                        {
                            Id = "3",
                            Nombre = "Pollo guisado",
                            Descripcion = "Pollo cocido a fuego lento con cebolla, pimiento, ajo y otras especias.",
                            Imagen = "https://i.ytimg.com/vi/qtN0CMV0OsM/maxresdefault.jpg",
                            PaisId = 1,
                        }
                    }
                },
                new Pais
                {
                    Id = 2,
                    Nombre = "Puerto Rico",
                    Bandera = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/28/Flag_of_Puerto_Rico.svg/1200px-Flag_of_Puerto_Rico.svg.png",
                    Recetas = new List<Receta>
                    {
                        new Receta
                        {
                            Id = "4",
                            Nombre = "Mofongo",
                            Descripcion = "Plato hecho a base de plátano verde frito y machacado con ajo y chicharrón de cerdo, relleno con carne, mariscos o vegetales.",
                            Imagen = "https://www.tureceta.net/wp-content/uploads/2020/03/Mofongo-Puertorique%C3%B1o-1.jpg",
                            PaisId = 2,
                        },
                        new Receta
                        {
                            Id = "5",
                            Nombre = "Arroz con gandules",
                            Descripcion = "Arroz cocido con gandules (guisantes), cerdo, tocino, cebolla, ajo y otros condimentos.",
                            Imagen = "https://i0.wp.com/www.averageguygourmet.com/wp-content/uploads/2016/11/Rice-Raw.jpg",
                            PaisId = 2,
                        },
                        new Receta
                        {
                            Id = "6",
                            Nombre = "Lechón asado",
                            Descripcion = "Cerdo entero asado a la parrilla, adobado con ajo, sal y otras especias.",
                            Imagen = "https://st1.uvnimg.com/a2/ce/78ea63c54d88898c538e4460e519/ap-lechon-asado.jpg",
                            PaisId = 2,
                        }
                    }
                },
                new Pais
                {
                    Id = 3,
                    Nombre = "Colombia",
                    Bandera = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Flag_of_Colombia.svg/1200px-Flag_of_Colombia.svg.png",
                    Recetas = new List<Receta>
                    {
                        new Receta
                        {
                            Id = "7",
                            Nombre = "Bandeja paisa",
                            Descripcion = "Plato típico de la región de Antioquia, compuesto por arroz, frijoles, chicharrón, carne molida, chorizo, huevo frito, plátano maduro y aguacate.",
                            Imagen = "https://www.196flavors.com/wp-content/uploads/2021/06/bandeja-paisa-2fp.jpg",
                            PaisId = 3,
                        },
                        new Receta
                        {
                            Id = "8",
                            Nombre = "Ajiaco",
                            Descripcion = "Sopa espesa hecha con tres tipos de papas, pollo, maíz, alcaparras, crema de leche y guascas (hierba nativa de la región andina).",
                            Imagen = "https://cdn.cookmonkeys.es/recetas/medium/ajiaco-bogotano-4914.jpg",
                            PaisId = 3,
                        },
                        new Receta
                        {
                            Id = "9",
                            Nombre = "Arepa",
                            Descripcion = "Pan redondo hecho a base de masa de maíz, común en toda Colombia y Venezuela, y que puede ser relleno con queso, huevo, carne, aguacate, frijoles, entre otros ingredientes.",
                            Imagen = "https://www.campi.com.co/wp-content/uploads/2021/01/origen-y-curiosidades-de-las-arepas-colombianas-imagen-destacadas.jpg",
                            PaisId = 3,
                        }
                    }
            }
        };
    }
}
