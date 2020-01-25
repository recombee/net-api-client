using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
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
        
        /// <summary>Asynchronously send the GetItemPropertyInfo request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<PropertyInfo> SendAsync(GetItemPropertyInfo request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the GetItemPropertyInfo request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public PropertyInfo Send(GetItemPropertyInfo request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<PropertyInfo> ParseResponse(string json, ListItemProperties request)
        {
            return JsonConvert.DeserializeObject<PropertyInfo[]>(json);
        }
        
        /// <summary>Asynchronously send the ListItemProperties request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<PropertyInfo>> SendAsync(ListItemProperties request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListItemProperties request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<PropertyInfo> Send(ListItemProperties request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
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
        
        /// <summary>Asynchronously send the ListSeries request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<Series>> SendAsync(ListSeries request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListSeries request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Series> Send(ListSeries request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<SeriesItem> ParseResponse(string json, ListSeriesItems request)
        {
            return JsonConvert.DeserializeObject<SeriesItem[]>(json);
        }
        
        /// <summary>Asynchronously send the ListSeriesItems request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<SeriesItem>> SendAsync(ListSeriesItems request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListSeriesItems request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<SeriesItem> Send(ListSeriesItems request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
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
        
        /// <summary>Asynchronously send the ListGroups request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<Group>> SendAsync(ListGroups request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListGroups request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Group> Send(ListGroups request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<GroupItem> ParseResponse(string json, ListGroupItems request)
        {
            return JsonConvert.DeserializeObject<GroupItem[]>(json);
        }
        
        /// <summary>Asynchronously send the ListGroupItems request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<GroupItem>> SendAsync(ListGroupItems request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListGroupItems request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<GroupItem> Send(ListGroupItems request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected PropertyInfo ParseResponse(string json, GetUserPropertyInfo request)
        {
            return JsonConvert.DeserializeObject<PropertyInfo>(json);
        }
        
        /// <summary>Asynchronously send the GetUserPropertyInfo request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<PropertyInfo> SendAsync(GetUserPropertyInfo request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the GetUserPropertyInfo request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public PropertyInfo Send(GetUserPropertyInfo request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<PropertyInfo> ParseResponse(string json, ListUserProperties request)
        {
            return JsonConvert.DeserializeObject<PropertyInfo[]>(json);
        }
        
        /// <summary>Asynchronously send the ListUserProperties request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<PropertyInfo>> SendAsync(ListUserProperties request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListUserProperties request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<PropertyInfo> Send(ListUserProperties request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<DetailView> ParseResponse(string json, ListItemDetailViews request)
        {
            return JsonConvert.DeserializeObject<DetailView[]>(json);
        }
        
        /// <summary>Asynchronously send the ListItemDetailViews request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<DetailView>> SendAsync(ListItemDetailViews request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListItemDetailViews request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<DetailView> Send(ListItemDetailViews request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<DetailView> ParseResponse(string json, ListUserDetailViews request)
        {
            return JsonConvert.DeserializeObject<DetailView[]>(json);
        }
        
        /// <summary>Asynchronously send the ListUserDetailViews request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<DetailView>> SendAsync(ListUserDetailViews request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListUserDetailViews request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<DetailView> Send(ListUserDetailViews request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<Purchase> ParseResponse(string json, ListItemPurchases request)
        {
            return JsonConvert.DeserializeObject<Purchase[]>(json);
        }
        
        /// <summary>Asynchronously send the ListItemPurchases request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<Purchase>> SendAsync(ListItemPurchases request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListItemPurchases request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Purchase> Send(ListItemPurchases request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<Purchase> ParseResponse(string json, ListUserPurchases request)
        {
            return JsonConvert.DeserializeObject<Purchase[]>(json);
        }
        
        /// <summary>Asynchronously send the ListUserPurchases request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<Purchase>> SendAsync(ListUserPurchases request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListUserPurchases request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Purchase> Send(ListUserPurchases request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<Rating> ParseResponse(string json, ListItemRatings request)
        {
            return JsonConvert.DeserializeObject<Rating[]>(json);
        }
        
        /// <summary>Asynchronously send the ListItemRatings request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<Rating>> SendAsync(ListItemRatings request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListItemRatings request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Rating> Send(ListItemRatings request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<Rating> ParseResponse(string json, ListUserRatings request)
        {
            return JsonConvert.DeserializeObject<Rating[]>(json);
        }
        
        /// <summary>Asynchronously send the ListUserRatings request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<Rating>> SendAsync(ListUserRatings request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListUserRatings request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Rating> Send(ListUserRatings request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<CartAddition> ParseResponse(string json, ListItemCartAdditions request)
        {
            return JsonConvert.DeserializeObject<CartAddition[]>(json);
        }
        
        /// <summary>Asynchronously send the ListItemCartAdditions request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<CartAddition>> SendAsync(ListItemCartAdditions request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListItemCartAdditions request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<CartAddition> Send(ListItemCartAdditions request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<CartAddition> ParseResponse(string json, ListUserCartAdditions request)
        {
            return JsonConvert.DeserializeObject<CartAddition[]>(json);
        }
        
        /// <summary>Asynchronously send the ListUserCartAdditions request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<CartAddition>> SendAsync(ListUserCartAdditions request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListUserCartAdditions request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<CartAddition> Send(ListUserCartAdditions request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<Bookmark> ParseResponse(string json, ListItemBookmarks request)
        {
            return JsonConvert.DeserializeObject<Bookmark[]>(json);
        }
        
        /// <summary>Asynchronously send the ListItemBookmarks request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<Bookmark>> SendAsync(ListItemBookmarks request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListItemBookmarks request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Bookmark> Send(ListItemBookmarks request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<Bookmark> ParseResponse(string json, ListUserBookmarks request)
        {
            return JsonConvert.DeserializeObject<Bookmark[]>(json);
        }
        
        /// <summary>Asynchronously send the ListUserBookmarks request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<Bookmark>> SendAsync(ListUserBookmarks request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListUserBookmarks request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Bookmark> Send(ListUserBookmarks request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<ViewPortion> ParseResponse(string json, ListItemViewPortions request)
        {
            return JsonConvert.DeserializeObject<ViewPortion[]>(json);
        }
        
        /// <summary>Asynchronously send the ListItemViewPortions request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<ViewPortion>> SendAsync(ListItemViewPortions request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListItemViewPortions request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<ViewPortion> Send(ListItemViewPortions request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<ViewPortion> ParseResponse(string json, ListUserViewPortions request)
        {
            return JsonConvert.DeserializeObject<ViewPortion[]>(json);
        }
        
        /// <summary>Asynchronously send the ListUserViewPortions request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<ViewPortion>> SendAsync(ListUserViewPortions request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListUserViewPortions request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<ViewPortion> Send(ListUserViewPortions request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected RecommendationResponse ParseResponse(string json, RecommendItemsToUser request)
        {
            return JsonConvert.DeserializeObject<RecommendationResponse>(json);
        }
        
        /// <summary>Asynchronously send the RecommendItemsToUser request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<RecommendationResponse> SendAsync(RecommendItemsToUser request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the RecommendItemsToUser request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public RecommendationResponse Send(RecommendItemsToUser request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected RecommendationResponse ParseResponse(string json, RecommendUsersToUser request)
        {
            return JsonConvert.DeserializeObject<RecommendationResponse>(json);
        }
        
        /// <summary>Asynchronously send the RecommendUsersToUser request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<RecommendationResponse> SendAsync(RecommendUsersToUser request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the RecommendUsersToUser request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public RecommendationResponse Send(RecommendUsersToUser request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected RecommendationResponse ParseResponse(string json, RecommendItemsToItem request)
        {
            return JsonConvert.DeserializeObject<RecommendationResponse>(json);
        }
        
        /// <summary>Asynchronously send the RecommendItemsToItem request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<RecommendationResponse> SendAsync(RecommendItemsToItem request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the RecommendItemsToItem request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public RecommendationResponse Send(RecommendItemsToItem request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected RecommendationResponse ParseResponse(string json, RecommendUsersToItem request)
        {
            return JsonConvert.DeserializeObject<RecommendationResponse>(json);
        }
        
        /// <summary>Asynchronously send the RecommendUsersToItem request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<RecommendationResponse> SendAsync(RecommendUsersToItem request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the RecommendUsersToItem request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public RecommendationResponse Send(RecommendUsersToItem request)
        {
            var task = SendAsync(request);
            RaiseExceptionOnFault(task);
            return task.Result;
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
            
            if (request is RecommendItemsToUser) return ParseResponse(json, (RecommendItemsToUser) request); 
            
            if (request is RecommendUsersToUser) return ParseResponse(json, (RecommendUsersToUser) request); 
            
            if (request is RecommendItemsToItem) return ParseResponse(json, (RecommendItemsToItem) request); 
            
            if (request is RecommendUsersToItem) return ParseResponse(json, (RecommendUsersToItem) request); 
            
            if (request is UserBasedRecommendation) return ParseResponse(json, (UserBasedRecommendation) request); 
            
            if (request is ItemBasedRecommendation) return ParseResponse(json, (ItemBasedRecommendation) request); 
            return ParseResponse(json, request);
        }
    }
}
