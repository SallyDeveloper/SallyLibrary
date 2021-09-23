﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using SallyLibrary.App.Brokers.Storages;
using SallyLibrary.App.Models.Books;

namespace SallyLibrary.App.Services.Foundations.Books
{
    public class BookService : IBookService
    {
        private readonly IStorageBroker storageBroker;

        public BookService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public Book AddBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}