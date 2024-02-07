using System;
using System.Collections.Generic;
using System.Linq;

namespace SneakerHunt
{
    public class SneakerRepository
    {
        private readonly List<Sneaker> _sneakers = [];

        // Добавя маратонка в колекцията
        public void Add(Sneaker sneaker)
        {
            // Ако ID на маратонката вече съществува, не добавяме дубликат
            if (!_sneakers.Any(s => s.Id == sneaker.Id))
            {
                _sneakers.Add(sneaker);
            }
        }

        // Връща всички маратонки
        public IEnumerable<Sneaker> GetAll()
        {
            return _sneakers;
        }

        // Намира маратонка по ID
        public Sneaker GetById(int id)
        {
            return _sneakers.FirstOrDefault(s => s.Id == id);
        }

        // Актуализира дадена маратонка
        public void Update(Sneaker sneaker)
        {
            var existingSneaker = _sneakers.FirstOrDefault(s => s.Id == sneaker.Id);
            if (existingSneaker != null)
            {
                _sneakers.Remove(existingSneaker);
                _sneakers.Add(sneaker);
            }
        }

        // Изтрива маратонка по ID
        public void Delete(int id)
        {
            var sneaker = _sneakers.FirstOrDefault(s => s.Id == id);
            if (sneaker != null)
            {
                _sneakers.Remove(sneaker);
            }
        }
    }
}