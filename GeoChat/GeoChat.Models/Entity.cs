namespace GeoChat.Models
{
    /// <summary>
    /// Base class for entities
    /// </summary>
    public abstract class Entity
    {

        public int Id { get; set; }

        /// <summary>
        /// Check if this entity is transient, ie, without identity at this moment
        /// </summary>
        /// <returns>True if entity is transient, else false</returns>
        public bool IsTransient()
        {
            return this.Id == 0;
        }

        public void SetIdentificator(int id)
        {
            Id = id;
        }

        #region Overrides Methods

        public override bool Equals(object obj)
        {
            // Comparing to null or different type?
            if (obj == null || GetType() != obj.GetType())
                return false;

            // Do they share the same reference?
            if (ReferenceEquals(this, obj))
                return true;

            var item = (Entity)obj;

            // Do they have identity?
            if (item.IsTransient() || IsTransient())
                return false;
            else
                return item.Id == Id;
        }

        public override int GetHashCode()
        {
            int hash = 37;
            hash = hash * 23 + base.GetHashCode();
            hash = hash * 23 + Id.GetHashCode();
            return hash;
        }


        public static bool operator ==(Entity left, Entity right)
        {
            if (Equals(left, null))
                return (Equals(right, null));
            return left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }

        #endregion


    }
}