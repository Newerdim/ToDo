using System.Collections.Generic;
using System.Threading.Tasks;
using ToDo.API.Dto;

namespace ToDo.API.Services
{
    public interface IToDoService
    {
        /// <summary>
        ///     Create to-do
        /// </summary>
        /// <param name="userId">User id</param>
        /// <param name="toDoToCreate">To-do</param>
        /// <returns>Created to-do</returns>
        public Task<Dto.ToDo> CreateAsync(int userId, ToDoToCreate toDoToCreate);

        /// <summary>
        ///     Get all to-do's from user
        /// </summary>
        /// <param name="userId">User id</param>
        /// <returns>To-do's</returns>
        public Task<ICollection<Dto.ToDo>> GetAllFromUserAsync(int userId);

        /// <summary>
        ///     Get to-do by id from user
        /// </summary>
        /// <param name="userId">User id</param>
        /// <param name="id">To-do id</param>
        /// <returns>To-do if exists; otherwise, null</returns>
        public Task<Dto.ToDo> GetByIdFromUserAsync(int userId, int id);
    }
}