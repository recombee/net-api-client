/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using Recombee.ApiClient.Util;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>Group Binding</summary>
    public class Group: Entity {
        private readonly string groupId;
        /// <summary>Id of the group</summary>
        [JsonProperty("groupId")]
        public string GroupId
        {
            get {return groupId;}
        }
    
        public Group (string groupId, Dictionary<string, object> values = null): base(values)
        {
            this.groupId = groupId;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is Group))
                 return false;
             if (obj == this)
                 return true;
        
             Group that = (Group) obj;
             return new EqualsBuilder<Group>(this, that)
                .With(m => m.GroupId)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<Group>(this)
                .With(m => m.GroupId)
                .HashCode;
        }
    }
    
}
