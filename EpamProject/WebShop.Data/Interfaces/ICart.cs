﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Data.Models;

namespace WebShop.Data.Interfaces
{
    public interface ICart
    {
        Cart GetByID(int id);
        IEnumerable<Cart> GetAll();

        //User ID
        IEnumerable<CartItem> GetItems(string id);

        Cart GetByUserID(string id);
        Task Add(Cart cart);
        Task AddCartItem(CartItem cartItem);
        Task AddItemToCart(Product product, string id);
        Task Delete(int id);
        Task Clear();
        Task GetTotal();
    }
}
