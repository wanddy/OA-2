namespace OA.Framework.DomainModel
{
    using System;
    using System.Collections.Generic;

    public abstract class AggregateRootBase<TId> : IAggregateRoot<TId>
    {
        private readonly ICollection<object> uncommitedEvents = new List<object>();


        protected AggregateRootBase(TId id)
        {
            this.Id = id;
        }

        protected AggregateRootBase()
        {
        }

        protected DateTime? PersistedDate { get; set; }

        public virtual TId Id { get; private set; }

        public IEnumerable<object> UncommitedEvents
        {
            get
            {
                return this.uncommitedEvents;
            }
        }

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