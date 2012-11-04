namespace OA.Framework.DomainModel
{
    public abstract class AggregateRootBase<TId> : IAggregateRoot<TId>
    {
        protected AggregateRootBase(TId id)
        {
            this.Id = id;
        }

        public virtual TId Id { get; private set; }

        public static bool operator ==(AggregateRootBase<TId> left, AggregateRootBase<TId> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AggregateRootBase<TId> left, AggregateRootBase<TId> right)
        {
            return !Equals(left, right);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType() || !ReferenceEquals(this, obj))
            {
                return false;
            }

            return this.Equals(obj as AggregateRootBase<TId>);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var result = 0;
                result = (result * 397) ^ this.Id.GetHashCode();
                return result;
            }
        }

        protected virtual bool Equals(AggregateRootBase<TId> obj)
        {
            return this.Id.Equals(obj.Id);
        }
    }
}