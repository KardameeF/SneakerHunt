using System.Collections.Generic;

namespace SneakerHunt
{
    public class SneakerService(SneakerRepository sneakerRepository)
    {
        private readonly SneakerRepository _sneakerRepository = sneakerRepository;

        // Взима всички маратонки
        public IEnumerable<Sneaker> GetAllSneakers()
        {
            return _sneakerRepository.GetAll();
        }

        // Добавя нова маратонка
        public void AddSneaker(Sneaker sneaker)
        {
            _sneakerRepository.Add(sneaker);
        }

        // Актуализира съществуваща маратонка
        public void UpdateSneaker(Sneaker sneaker)
        {
            _sneakerRepository.Update(sneaker);
        }

        // Взима маратонка по ID
        public Sneaker GetSneakerById(int id)
        {
            return _sneakerRepository.GetById(id);
        }

        // Изтрива маратонка по ID
        public void DeleteSneaker(int id)
        {
            _sneakerRepository.Delete(id);
        }
    }
}