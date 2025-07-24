using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nito.AsyncEx.Synchronous;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected UpdateMoreItemsResponse ParseResponse(string json, UpdateMoreItems request)
        {
            return JsonConvert.DeserializeObject<UpdateMoreItemsResponse>(json);
        }
        
        /// <summary>Asynchronously send the UpdateMoreItems request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<UpdateMoreItemsResponse> SendAsync(UpdateMoreItems request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the UpdateMoreItems request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public UpdateMoreItemsResponse Send(UpdateMoreItems request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected DeleteMoreItemsResponse ParseResponse(string json, DeleteMoreItems request)
        {
            return JsonConvert.DeserializeObject<DeleteMoreItemsResponse>(json);
        }
        
        /// <summary>Asynchronously send the DeleteMoreItems request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<DeleteMoreItemsResponse> SendAsync(DeleteMoreItems request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the DeleteMoreItems request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public DeleteMoreItemsResponse Send(DeleteMoreItems request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected RecommendationResponse ParseResponse(string json, RecommendItemsToItemSegment request)
        {
            return JsonConvert.DeserializeObject<RecommendationResponse>(json);
        }
        
        /// <summary>Asynchronously send the RecommendItemsToItemSegment request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<RecommendationResponse> SendAsync(RecommendItemsToItemSegment request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the RecommendItemsToItemSegment request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public RecommendationResponse Send(RecommendItemsToItemSegment request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected RecommendationResponse ParseResponse(string json, RecommendNextItems request)
        {
            return JsonConvert.DeserializeObject<RecommendationResponse>(json);
        }
        
        /// <summary>Asynchronously send the RecommendNextItems request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<RecommendationResponse> SendAsync(RecommendNextItems request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the RecommendNextItems request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public RecommendationResponse Send(RecommendNextItems request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
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
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected RecommendationResponse ParseResponse(string json, RecommendItemSegmentsToUser request)
        {
            return JsonConvert.DeserializeObject<RecommendationResponse>(json);
        }
        
        /// <summary>Asynchronously send the RecommendItemSegmentsToUser request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<RecommendationResponse> SendAsync(RecommendItemSegmentsToUser request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the RecommendItemSegmentsToUser request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public RecommendationResponse Send(RecommendItemSegmentsToUser request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected RecommendationResponse ParseResponse(string json, RecommendItemSegmentsToItem request)
        {
            return JsonConvert.DeserializeObject<RecommendationResponse>(json);
        }
        
        /// <summary>Asynchronously send the RecommendItemSegmentsToItem request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<RecommendationResponse> SendAsync(RecommendItemSegmentsToItem request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the RecommendItemSegmentsToItem request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public RecommendationResponse Send(RecommendItemSegmentsToItem request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected RecommendationResponse ParseResponse(string json, RecommendItemSegmentsToItemSegment request)
        {
            return JsonConvert.DeserializeObject<RecommendationResponse>(json);
        }
        
        /// <summary>Asynchronously send the RecommendItemSegmentsToItemSegment request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<RecommendationResponse> SendAsync(RecommendItemSegmentsToItemSegment request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the RecommendItemSegmentsToItemSegment request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public RecommendationResponse Send(RecommendItemSegmentsToItemSegment request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected SearchResponse ParseResponse(string json, SearchItems request)
        {
            return JsonConvert.DeserializeObject<SearchResponse>(json);
        }
        
        /// <summary>Asynchronously send the SearchItems request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<SearchResponse> SendAsync(SearchItems request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the SearchItems request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public SearchResponse Send(SearchItems request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected SearchResponse ParseResponse(string json, SearchItemSegments request)
        {
            return JsonConvert.DeserializeObject<SearchResponse>(json);
        }
        
        /// <summary>Asynchronously send the SearchItemSegments request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<SearchResponse> SendAsync(SearchItemSegments request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the SearchItemSegments request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public SearchResponse Send(SearchItemSegments request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected SearchSynonym ParseResponse(string json, AddSearchSynonym request)
        {
            return JsonConvert.DeserializeObject<SearchSynonym>(json);
        }
        
        /// <summary>Asynchronously send the AddSearchSynonym request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<SearchSynonym> SendAsync(AddSearchSynonym request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the AddSearchSynonym request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public SearchSynonym Send(AddSearchSynonym request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected ListSearchSynonymsResponse ParseResponse(string json, ListSearchSynonyms request)
        {
            return JsonConvert.DeserializeObject<ListSearchSynonymsResponse>(json);
        }
        
        /// <summary>Asynchronously send the ListSearchSynonyms request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<ListSearchSynonymsResponse> SendAsync(ListSearchSynonyms request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListSearchSynonyms request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public ListSearchSynonymsResponse Send(ListSearchSynonyms request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected ListSegmentationsResponse ParseResponse(string json, ListSegmentations request)
        {
            return JsonConvert.DeserializeObject<ListSegmentationsResponse>(json);
        }
        
        /// <summary>Asynchronously send the ListSegmentations request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<ListSegmentationsResponse> SendAsync(ListSegmentations request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListSegmentations request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public ListSegmentationsResponse Send(ListSegmentations request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected Segmentation ParseResponse(string json, GetSegmentation request)
        {
            return JsonConvert.DeserializeObject<Segmentation>(json);
        }
        
        /// <summary>Asynchronously send the GetSegmentation request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<Segmentation> SendAsync(GetSegmentation request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the GetSegmentation request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public Segmentation Send(GetSegmentation request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }
        
        
        /// <summary>Parse JSON response</summary>
        /// <param name="json">JSON string from the API</param>
        /// <param name="request">Request sent to the API</param>
        /// <returns>Parsed response</returns>
        protected IEnumerable<Scenario> ParseResponse(string json, ListScenarios request)
        {
            return JsonConvert.DeserializeObject<Scenario[]>(json);
        }
        
        /// <summary>Asynchronously send the ListScenarios request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Task representing the asynchronous operation</returns>
        public async Task<IEnumerable<Scenario>> SendAsync(ListScenarios request)
        {
            var json = await SendRequestAsync(request);
            return ParseResponse(json, request);
        }
        
        /// <summary>Synchronously send the ListScenarios request</summary>
        /// <param name="request">Request to be sent</param>
        /// <returns>Response from the API</returns>
        public IEnumerable<Scenario> Send(ListScenarios request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }
        
        private object ParseOneBatchResponse(string json, int statusCode, Request request)
        {
            if(statusCode<200 || statusCode > 299) return new ResponseException(request, (HttpStatusCode)statusCode, json);
        
            if (request is GetItemValues) return ParseResponse(json, (GetItemValues) request); 
            
            if (request is ListItems) return ParseResponse(json, (ListItems) request); 
            
            if (request is GetItemPropertyInfo) return ParseResponse(json, (GetItemPropertyInfo) request); 
            
            if (request is ListItemProperties) return ParseResponse(json, (ListItemProperties) request); 
            
            if (request is UpdateMoreItems) return ParseResponse(json, (UpdateMoreItems) request); 
            
            if (request is DeleteMoreItems) return ParseResponse(json, (DeleteMoreItems) request); 
            
            if (request is ListSeries) return ParseResponse(json, (ListSeries) request); 
            
            if (request is ListSeriesItems) return ParseResponse(json, (ListSeriesItems) request); 
            
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
            
            if (request is RecommendItemsToItem) return ParseResponse(json, (RecommendItemsToItem) request); 
            
            if (request is RecommendItemsToItemSegment) return ParseResponse(json, (RecommendItemsToItemSegment) request); 
            
            if (request is RecommendNextItems) return ParseResponse(json, (RecommendNextItems) request); 
            
            if (request is RecommendUsersToUser) return ParseResponse(json, (RecommendUsersToUser) request); 
            
            if (request is RecommendUsersToItem) return ParseResponse(json, (RecommendUsersToItem) request); 
            
            if (request is RecommendItemSegmentsToUser) return ParseResponse(json, (RecommendItemSegmentsToUser) request); 
            
            if (request is RecommendItemSegmentsToItem) return ParseResponse(json, (RecommendItemSegmentsToItem) request); 
            
            if (request is RecommendItemSegmentsToItemSegment) return ParseResponse(json, (RecommendItemSegmentsToItemSegment) request); 
            
            if (request is SearchItems) return ParseResponse(json, (SearchItems) request); 
            
            if (request is SearchItemSegments) return ParseResponse(json, (SearchItemSegments) request); 
            
            if (request is AddSearchSynonym) return ParseResponse(json, (AddSearchSynonym) request); 
            
            if (request is ListSearchSynonyms) return ParseResponse(json, (ListSearchSynonyms) request); 
            
            if (request is ListSegmentations) return ParseResponse(json, (ListSegmentations) request); 
            
            if (request is GetSegmentation) return ParseResponse(json, (GetSegmentation) request); 
            
            if (request is ListScenarios) return ParseResponse(json, (ListScenarios) request); 
            return ParseResponse(json, request);
        }
    }
}
