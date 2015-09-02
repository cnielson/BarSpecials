using System;

namespace Specials.Domain
{
    // todo: fix this crap
    public class Identifier
    {
        public string Value { get; set; }

        public Identifier()
        {
            Value = Guid.NewGuid().ToString().ToLower();
        }

        public Identifier(string value)
        {
            Value = value;
        }

        public static Identifier New()
        {
            return new Identifier(Guid.NewGuid().ToString().ToLower().Replace("-", ""));
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
