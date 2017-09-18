using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Recombee.ApiClient.ApiRequests;
using Recombee.ApiClient.Bindings;

namespace Recombee.ApiClient
{
    public partial class RecombeeClient
    {
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected PropertyInfo ParseResponse(string json, GetItemPropertyInfo request)
        {
            return JsonConvert.DeserializeObject<PropertyInfo>(json);
        }
        
        /// <summary>Send the GetItemPropertyInfo request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public PropertyInfo Send(GetItemPropertyInfo request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<PropertyInfo> ParseResponse(string json, ListItemProperties request)
        {
            return JsonConvert.DeserializeObject<PropertyInfo[]>(json);
        }
        
        /// <summary>Send the ListItemProperties request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<PropertyInfo> Send(ListItemProperties request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<Series> ParseResponse(string json, ListSeries request)
        {
            var strArray = JsonConvert.DeserializeObject<string[]>(json);
            return strArray.Select(x => new Series(x));
        }
        
        /// <summary>Send the ListSeries request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Series> Send(ListSeries request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<SeriesItem> ParseResponse(string json, ListSeriesItems request)
        {
            return JsonConvert.DeserializeObject<SeriesItem[]>(json);
        }
        
        /// <summary>Send the ListSeriesItems request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<SeriesItem> Send(ListSeriesItems request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<Group> ParseResponse(string json, ListGroups request)
        {
            var strArray = JsonConvert.DeserializeObject<string[]>(json);
            return strArray.Select(x => new Group(x));
        }
        
        /// <summary>Send the ListGroups request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Group> Send(ListGroups request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<GroupItem> ParseResponse(string json, ListGroupItems request)
        {
            return JsonConvert.DeserializeObject<GroupItem[]>(json);
        }
        
        /// <summary>Send the ListGroupItems request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<GroupItem> Send(ListGroupItems request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected PropertyInfo ParseResponse(string json, GetUserPropertyInfo request)
        {
            return JsonConvert.DeserializeObject<PropertyInfo>(json);
        }
        
        /// <summary>Send the GetUserPropertyInfo request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public PropertyInfo Send(GetUserPropertyInfo request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<PropertyInfo> ParseResponse(string json, ListUserProperties request)
        {
            return JsonConvert.DeserializeObject<PropertyInfo[]>(json);
        }
        
        /// <summary>Send the ListUserProperties request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<PropertyInfo> Send(ListUserProperties request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<DetailView> ParseResponse(string json, ListItemDetailViews request)
        {
            return JsonConvert.DeserializeObject<DetailView[]>(json);
        }
        
        /// <summary>Send the ListItemDetailViews request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<DetailView> Send(ListItemDetailViews request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<DetailView> ParseResponse(string json, ListUserDetailViews request)
        {
            return JsonConvert.DeserializeObject<DetailView[]>(json);
        }
        
        /// <summary>Send the ListUserDetailViews request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<DetailView> Send(ListUserDetailViews request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<Purchase> ParseResponse(string json, ListItemPurchases request)
        {
            return JsonConvert.DeserializeObject<Purchase[]>(json);
        }
        
        /// <summary>Send the ListItemPurchases request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Purchase> Send(ListItemPurchases request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<Purchase> ParseResponse(string json, ListUserPurchases request)
        {
            return JsonConvert.DeserializeObject<Purchase[]>(json);
        }
        
        /// <summary>Send the ListUserPurchases request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Purchase> Send(ListUserPurchases request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<Rating> ParseResponse(string json, ListItemRatings request)
        {
            return JsonConvert.DeserializeObject<Rating[]>(json);
        }
        
        /// <summary>Send the ListItemRatings request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Rating> Send(ListItemRatings request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<Rating> ParseResponse(string json, ListUserRatings request)
        {
            return JsonConvert.DeserializeObject<Rating[]>(json);
        }
        
        /// <summary>Send the ListUserRatings request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Rating> Send(ListUserRatings request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<CartAddition> ParseResponse(string json, ListItemCartAdditions request)
        {
            return JsonConvert.DeserializeObject<CartAddition[]>(json);
        }
        
        /// <summary>Send the ListItemCartAdditions request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<CartAddition> Send(ListItemCartAdditions request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<CartAddition> ParseResponse(string json, ListUserCartAdditions request)
        {
            return JsonConvert.DeserializeObject<CartAddition[]>(json);
        }
        
        /// <summary>Send the ListUserCartAdditions request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<CartAddition> Send(ListUserCartAdditions request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<Bookmark> ParseResponse(string json, ListItemBookmarks request)
        {
            return JsonConvert.DeserializeObject<Bookmark[]>(json);
        }
        
        /// <summary>Send the ListItemBookmarks request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Bookmark> Send(ListItemBookmarks request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<Bookmark> ParseResponse(string json, ListUserBookmarks request)
        {
            return JsonConvert.DeserializeObject<Bookmark[]>(json);
        }
        
        /// <summary>Send the ListUserBookmarks request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Bookmark> Send(ListUserBookmarks request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<ViewPortion> ParseResponse(string json, ListItemViewPortions request)
        {
            return JsonConvert.DeserializeObject<ViewPortion[]>(json);
        }
        
        /// <summary>Send the ListItemViewPortions request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<ViewPortion> Send(ListItemViewPortions request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<ViewPortion> ParseResponse(string json, ListUserViewPortions request)
        {
            return JsonConvert.DeserializeObject<ViewPortion[]>(json);
        }
        
        /// <summary>Send the ListUserViewPortions request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<ViewPortion> Send(ListUserViewPortions request)
        {
            var json = SendRequest(request);
            return ParseResponse(json, request);
        }
        private object ParseOneBatchResponse(string json, int statusCode, Request request)
        {
            if(statusCode<200 || statusCode > 299) return new ResponseException(request, (HttpStatusCode)statusCode, json);
        
            if (request is GetItemValues) return ParseResponse(json, (GetItemValues) request); 
            
            if (request is ListItems) return ParseResponse(json, (ListItems) request); 
            
            if (request is GetItemPropertyInfo) return ParseResponse(json, (GetItemPropertyInfo) request); 
            
            if (request is ListItemProperties) return ParseResponse(json, (ListItemProperties) request); 
            
            if (request is ListSeries) return ParseResponse(json, (ListSeries) request); 
            
            if (request is ListSeriesItems) return ParseResponse(json, (ListSeriesItems) request); 
            
            if (request is ListGroups) return ParseResponse(json, (ListGroups) request); 
            
            if (request is ListGroupItems) return ParseResponse(json, (ListGroupItems) request); 
            
            if (request is GetUserValues) return ParseResponse(json, (GetUserValues) request); 
            
            if (request is ListUsers) return ParseResponse(json, (ListUsers) request); 
            
            if (request is GetUserPropertyInfo) return ParseResponse(json, (GetUserPropertyInfo) request); 
            
            if (request is ListUserProperties) return ParseResponse(json, (ListUserProperties) request); 
            
            if (request is ListItemDetailViews) return ParseResponse(json, (ListItemDetailViews) request); 
            
            if (request is ListUserDetailViews) return ParseResponse(json, (ListUserDetailViews) request); 
            
            if (request is ListItemPurchases) return ParseResponse(json, (ListItemPurchases) request); 
            
            if (request is ListUserPurchases) return ParseResponse(json, (ListUserPurchases) request); 
            
            if (request is ListItemRatings) return ParseResponse(json, (ListItemRatings) request); 
            
            if (request is ListUserRatings) return ParseResponse(json, (ListUserRatings) request); 
            
            if (request is ListItemCartAdditions) return ParseResponse(json, (ListItemCartAdditions) request); 
            
            if (request is ListUserCartAdditions) return ParseResponse(json, (ListUserCartAdditions) request); 
            
            if (request is ListItemBookmarks) return ParseResponse(json, (ListItemBookmarks) request); 
            
            if (request is ListUserBookmarks) return ParseResponse(json, (ListUserBookmarks) request); 
            
            if (request is ListItemViewPortions) return ParseResponse(json, (ListItemViewPortions) request); 
            
            if (request is ListUserViewPortions) return ParseResponse(json, (ListUserViewPortions) request); 
            
            if (request is UserBasedRecommendation) return ParseResponse(json, (UserBasedRecommendation) request); 
            
            if (request is ItemBasedRecommendation) return ParseResponse(json, (ItemBasedRecommendation) request); 
            return ParseResponse(json, request);
        }
    }
}
