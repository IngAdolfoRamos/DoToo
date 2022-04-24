using DoToo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoToo.Repositories
{
    public class TodoItemRepository : ITodoItemRepository
    {
        public event EventHandler<TodoItem> OnItemAdded;
        public event EventHandler<TodoItem> OnItemUpdated;

        public Task<List<TodoItem>> GetItems()
        {
            return null;
        }

        public Task AddItem(TodoItem item)
        {
            return null;
        }

        public Task UpdateItem(TodoItem item)
        {
            return null;
        }

        public async Task AddOrUpdate(TodoItem item)
        {
            if(item.Id == 0)
            {
                await AddItem(item);
            }
            else
            {
                await UpdateItem(item);
            }
        }
    }
}
