using Formation.Models;
using Formation.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApiRestaurant.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    {
        Repository _repository = Repository.GetInstance();
        /// <summary>
        /// Get all restaurants from the dto
        /// </summary>
        /// <returns> list du restaurant </returns>
        [HttpGet]
        public List<Restaurant> GetAll()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            restaurants = _repository.Restaurants;
            return restaurants;
        }



        /// <summary>
        /// Get a restaurant by id
        /// </summary>
        /// <param name="id"> id de l element sollicité </param>
        /// <returns> Object restaurant </returns>

        [HttpGet("{id}")]
        public Restaurant GetById(string id)
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            restaurants = _repository.Restaurants;
            Restaurant res = restaurants.FirstOrDefault(x => x.Id == id);
            return res;
        }


        /// <summary>
        /// Modifier un restaurant donner par id
        /// </summary>
        /// <param name="id"> id de l element à modifier  </param>
        /// <param name="restaurant"> la nouvel version de l element avec id   </param>
        /// <returns> Object restaurant modifié  </returns>
        [HttpPut("{id}")]
        public Restaurant Update(string id, Restaurant restaurant)
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            restaurants = _repository.Restaurants;
            Restaurant res = restaurants.FirstOrDefault(x => x.Id == id);
            res.Name = restaurant.Name;
            res.Location = restaurant.Location;
            res.Cuisines = restaurant.Cuisines;
            return res;
        }



        /// <summary>
        /// Api pour ajouter un restaurant
        /// </summary>
        /// <param name="restaurant"> la nouveau item to add    </param>
        /// <returns> le restaurant ajouté   </returns>

        [HttpPost]
        public Restaurant Create(Restaurant restaurant)
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            restaurants = _repository.Restaurants;
            restaurants.Add(restaurant);
            return restaurant;
        }


        /// <summary>
        /// Api pour supprimer un restaurant
        /// </summary>
        /// <param name="id"> id of item to delete  </param>
        /// <returns> Rien  </returns>
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            restaurants = _repository.Restaurants;
            Restaurant res = restaurants.FirstOrDefault(x => x.Id == id);
            restaurants.Remove(res);
        }



        /// <summary>
        /// Api pour chercher tous les restaurants d'une cuisine donnée par son nom 
        /// </summary>
        /// <param name="cuisineName"> nom de la cuisine cherche   </param>
        /// <returns> liste des restaurants   </returns>
        [HttpGet("{cuisine}")]
        public List<Restaurant> GetByCuisine(string cuisineName)
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            List<Restaurant> restaurantCuisine = new List<Restaurant>();
            restaurants = _repository.Restaurants;
            foreach (var r in restaurants)
            {
                if (r.cuisine == cuisineName)
                {
                    restaurantCuisine.Add(r);
                }

            }
            return restaurantCuisine;
        }

    }
    }
