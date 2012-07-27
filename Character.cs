namespace Tutorial1
{
    public class Character
    {
        public int Damage
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int Health
        {
            get;
            set;
        }
        public bool Isstillalive
        {
            get
            {
                return this.Health > 0;
            }
        }
        public string HealthString
        {
            get
            {
                return string.Format("{0}'s health is {1}.", this.Name, this.Health);
            }
        }
        public string Hit(Character otherCharacter) 
        {
            if (!this.Isstillalive)
            {
                return string.Format("{0} cannot hit {1} becasue he is dead",this.Name,otherCharacter.Name);
            }
            var damage = RandomNumberGenerator.CalculateDamage(this.Damage);
            otherCharacter.Health = otherCharacter.Health - damage;
            return string.Format("{0} hits {1} for {2} hitpoints",this.Name,otherCharacter.Name,damage);
        }
    }
}