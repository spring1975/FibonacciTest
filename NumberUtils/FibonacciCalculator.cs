using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberUtils
{
    public class FibonacciCalculator
    {
        private readonly long _startValue;
        private List<long> _values;

        public FibonacciCalculator()
        {
            _startValue = 1;
        }

        public FibonacciCalculator(long startValue)
        {
            _startValue = startValue;
        }
        /// <summary>
        /// Used to find the position of a value in the fibonacci sequence
        /// Example: If sequence starts at 1, value 8 will be at position 5.
        /// </summary>
        /// <param name="positionValue"></param>
        /// <returns></returns>
        public long CalculatePositionOfValue(long positionValue)
        {
            InitializeList();
            do
            {
                //Safety check to avoid endless loop.
                if (_values.Last() > positionValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(positionValue));
                }

                _values.Add(CalculateNextFibonacciValue());
            }
            while (!_values.Contains(positionValue));

            return _values.Count;
        }

        /// <summary>
        /// Used to find the value of a position in the fibonacci sequence
        /// Example: If sequence starts at 1, position 5 will be of value 8.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public long CalculateValueOfPosition(int position)
        {
            InitializeList();
            for (var i = 2; i <= position; i++)
            {
                _values.Add(CalculateNextFibonacciValue());
            }

            return _values.Last();
        }

        /// <summary>
        /// Used to calculate the next value in the fibonacci sequence
        /// </summary>
        /// <returns></returns>
        private long CalculateNextFibonacciValue()
        {
            var previousValue = _values.Count == 1 ? 0 : _values[_values.Count - 1];
            var lastValue = _values.Last();
            return previousValue + lastValue;
        }
        private void InitializeList()
        {
            _values = new List<long> { _startValue };
        }
    }
}
