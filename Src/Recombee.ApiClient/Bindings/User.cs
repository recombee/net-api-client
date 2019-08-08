/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using Recombee.ApiClient.Util;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>User Binding</summary>
    public class User: Entity {
        private readonly string userId;
        /// <summary>Id of the user</summary>
        [JsonProperty("userId")]
        public string UserId
        {
            get {return userId;}
        }
    
        public User (string userId, Dictionary<string, object> values = null): base(values)
        {
            this.userId = userId;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is User))
                 return false;
             if (obj == this)
                 return true;
        
             User that = (User) obj;
             return new EqualsBuilder<User>(this, that)
                .With(m => m.UserId)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<User>(this)
                .With(m => m.UserId)
                .HashCode;
        }
    }
    
}
