#### Generics

The parameter of the method takes type T in both the IEnumerables<T> and T. Since the method compares values of type T, T must be comparable and therefore implements the interface IComparable<T>.

The type constrait for the second method is similar, the difference is just that T inherits from U and U inherits from the interface IComparable. By the rules of inheritage T will also inherit from IComparable.
