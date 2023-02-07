using MultiDataSourceGenericRepository.BL.Contexts;
using MultiDataSourceGenericRepository.BL.Models;
using MultiDataSourceGenericRepository.BL.Repositories;
using MultiDataSourceGenericRepository.BL.Repositories.Implements;
using System;
using System.Collections.Generic;

namespace MultiDataSourceGenericRepository
{
    internal class Program
    {
        private static IUnitOfWork _unitOfWork;

        static void Main(string[] args)
        {
            _unitOfWork = new UnitOfWork(new ContextNPG());
            IEnumerable<Blog> blogs = _unitOfWork.Repository<Blog>().Get(includeProperties: "Post");
            foreach (var blog in blogs)
            {
                Console.WriteLine($"===== Blog =====");
                Console.WriteLine($"Url: {blog.Url}");

                foreach (var post in blog.Post)
                {
                    Console.WriteLine($"===== Post =====");
                    Console.WriteLine($"Title: {post.Title}");
                    Console.WriteLine($"Content: {post.Content}");
                }                
            }

            Console.ReadKey();
        }
    }
}