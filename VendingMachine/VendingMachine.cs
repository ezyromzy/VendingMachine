﻿namespace VendingMachine
{
    internal class VendingMachine
    {
        private Good[] _goods;

        public VendingMachine(int balance, params Good[] goods)
        {
            _goods = goods;
            Balance = balance;
        }

        public int Balance { get; private set; }

        public void AddBalance(int delta)
        {
            if (delta < 0)
                throw new ArgumentOutOfRangeException("delta");

            Balance += delta;
        }

        public void DiscardBalance(int delta)
        {
            if (delta < 0 || Balance > delta)
                throw new ArgumentOutOfRangeException("delta");

            Balance -= delta;
        }

        public bool IsOrderPossible(IOrder order)
        {
            return order.IsAvailable && order.GetTotalPrice() <= Balance;
        }

        public bool TryProcessOrder(IOrder order)
        {
            if (IsOrderPossible(order))
            {
                Balance -= order.GetTotalPrice();
                order.Ship();
                return true;
            }
            else
                return false;
        }

        public bool IsContains(int id)
        {
            return id >= 0 && id < _goods.Length;
        }

        public Good GetFromId(int id)
        {
            if (!IsContains(id))
                throw new ArgumentOutOfRangeException("id");

            return _goods[id];
        }
    }
}
