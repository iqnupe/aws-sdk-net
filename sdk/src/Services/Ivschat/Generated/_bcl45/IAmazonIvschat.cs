/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ivschat-2020-07-14.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Ivschat.Model;

namespace Amazon.Ivschat
{
    /// <summary>
    /// Interface for accessing Ivschat
    ///
    /// <b>Introduction</b> 
    /// 
    ///  
    /// <para>
    /// The Amazon IVS Chat control-plane API enables you to create and manage Amazon IVS
    /// Chat resources. You also need to integrate with the <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/chat-messaging-api.html">
    /// Amazon IVS Chat Messaging API</a>, to enable users to interact with chat rooms in
    /// real time.
    /// </para>
    ///  
    /// <para>
    /// The API is an AWS regional service. For a list of supported regions and Amazon IVS
    /// Chat HTTPS service endpoints, see the Amazon IVS Chat information on the <a href="https://docs.aws.amazon.com/general/latest/gr/ivs.html">Amazon
    /// IVS page</a> in the <i>AWS General Reference</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Notes on terminology:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You create service applications using the Amazon IVS Chat API. We refer to these as
    /// <i>applications</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You create front-end client applications (browser and Android/iOS apps) using the
    /// Amazon IVS Chat Messaging API. We refer to these as <i>clients</i>. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// The following resource is part of Amazon IVS Chat:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Room</b> — The central Amazon IVS Chat resource through which clients connect
    /// to and exchange chat messages. See the Room endpoints for more information.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>API Access Security</b> 
    /// </para>
    ///  
    /// <para>
    /// Your Amazon IVS Chat applications (service applications and clients) must be authenticated
    /// and authorized to access Amazon IVS Chat resources. Note the differences between these
    /// concepts:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>Authentication</i> is about verifying identity. Requests to the Amazon IVS Chat
    /// API must be signed to verify your identity.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Authorization</i> is about granting permissions. Your IAM roles need to have permissions
    /// for Amazon IVS Chat API requests.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Users (viewers) connect to a room using secure access tokens that you create using
    /// the <a>CreateChatToken</a> endpoint through the AWS SDK. You call CreateChatToken
    /// for every user’s chat session, passing identity and authorization information about
    /// the user.
    /// </para>
    ///  
    /// <para>
    ///  <b>Signing API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// HTTP API requests must be signed with an AWS SigV4 signature using your AWS security
    /// credentials. The AWS Command Line Interface (CLI) and the AWS SDKs take care of signing
    /// the underlying API calls for you. However, if your application calls the Amazon IVS
    /// Chat HTTP API directly, it’s your responsibility to sign the requests.
    /// </para>
    ///  
    /// <para>
    /// You generate a signature using valid AWS credentials for an IAM role that has permission
    /// to perform the requested action. For example, DeleteMessage requests must be made
    /// using an IAM role that has the <code>ivschat:DeleteMessage</code> permission.
    /// </para>
    ///  
    /// <para>
    /// For more information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Authentication and generating signatures — See <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
    /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon Web Services
    /// General Reference</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Managing Amazon IVS permissions — See <a href="https://docs.aws.amazon.com/ivs/latest/userguide/security-iam.html">Identity
    /// and Access Management</a> on the Security page of the <i>Amazon IVS User Guide</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Messaging Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteMessage</a> — Sends an event to a specific room which directs clients to
    /// delete a specific message; that is, unrender it from view and delete it from the client’s
    /// chat history. This event’s <code>EventName</code> is <code>aws:DELETE_MESSAGE</code>.
    /// This replicates the <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/actions-deletemessage-publish.html">
    /// DeleteMessage</a> WebSocket operation in the Amazon IVS Chat Messaging API.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DisconnectUser</a> — Disconnects all connections using a specified user ID from
    /// a room. This replicates the <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/actions-disconnectuser-publish.html">
    /// DisconnectUser</a> WebSocket operation in the Amazon IVS Chat Messaging API.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>SendEvent</a> — Sends an event to a room. Use this within your application’s business
    /// logic to send events to clients of a room; e.g., to notify clients to change the way
    /// the chat UI is rendered.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Chat Token Endpoint</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateChatToken</a> — Creates an encrypted token that is used to establish an
    /// individual WebSocket connection to a room. The token is valid for one minute, and
    /// a connection (session) established with the token is valid for the specified duration.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Room Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateRoom</a> — Creates a room that allows clients to connect and pass messages.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteRoom</a> — Deletes the specified room.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetRoom</a> — Gets the specified room.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListRooms</a> — Gets summary information about all your rooms in the AWS region
    /// where the API request is processed. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateRoom</a> — Updates a room’s configuration.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tags Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a> — Gets information about AWS tags for the specified ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TagResource</a> — Adds or updates tags for the AWS resource with the specified
    /// ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a> — Removes tags from the resource with the specified ARN.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// All the above are HTTP operations. There is a separate <i>messaging</i> API for managing
    /// Chat resources; see the <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/chat-messaging-api.html">
    /// Amazon IVS Chat Messaging API Reference</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonIvschat : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIvschatPaginatorFactory Paginators { get; }

        
        #region  CreateChatToken


        /// <summary>
        /// Creates an encrypted token that is used to establish an individual WebSocket connection
        /// to a room. The token is valid for one minute, and a connection (session) established
        /// with the token is valid for the specified duration.
        /// 
        ///  
        /// <para>
        /// Encryption keys are owned by Amazon IVS Chat and never used directly by your application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChatToken service method.</param>
        /// 
        /// <returns>The response from the CreateChatToken service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/CreateChatToken">REST API Reference for CreateChatToken Operation</seealso>
        CreateChatTokenResponse CreateChatToken(CreateChatTokenRequest request);



        /// <summary>
        /// Creates an encrypted token that is used to establish an individual WebSocket connection
        /// to a room. The token is valid for one minute, and a connection (session) established
        /// with the token is valid for the specified duration.
        /// 
        ///  
        /// <para>
        /// Encryption keys are owned by Amazon IVS Chat and never used directly by your application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChatToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChatToken service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/CreateChatToken">REST API Reference for CreateChatToken Operation</seealso>
        Task<CreateChatTokenResponse> CreateChatTokenAsync(CreateChatTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRoom


        /// <summary>
        /// Creates a room that allows clients to connect and pass messages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoom service method.</param>
        /// 
        /// <returns>The response from the CreateRoom service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        CreateRoomResponse CreateRoom(CreateRoomRequest request);



        /// <summary>
        /// Creates a room that allows clients to connect and pass messages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRoom service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        Task<CreateRoomResponse> CreateRoomAsync(CreateRoomRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMessage


        /// <summary>
        /// Sends an event to a specific room which directs clients to delete a specific message;
        /// that is, unrender it from view and delete it from the client’s chat history. This
        /// event’s <code>EventName</code> is <code>aws:DELETE_MESSAGE</code>. This replicates
        /// the <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/actions-deletemessage-publish.html">
        /// DeleteMessage</a> WebSocket operation in the Amazon IVS Chat Messaging API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessage service method.</param>
        /// 
        /// <returns>The response from the DeleteMessage service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DeleteMessage">REST API Reference for DeleteMessage Operation</seealso>
        DeleteMessageResponse DeleteMessage(DeleteMessageRequest request);



        /// <summary>
        /// Sends an event to a specific room which directs clients to delete a specific message;
        /// that is, unrender it from view and delete it from the client’s chat history. This
        /// event’s <code>EventName</code> is <code>aws:DELETE_MESSAGE</code>. This replicates
        /// the <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/actions-deletemessage-publish.html">
        /// DeleteMessage</a> WebSocket operation in the Amazon IVS Chat Messaging API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMessage service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DeleteMessage">REST API Reference for DeleteMessage Operation</seealso>
        Task<DeleteMessageResponse> DeleteMessageAsync(DeleteMessageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRoom


        /// <summary>
        /// Deletes the specified room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoom service method.</param>
        /// 
        /// <returns>The response from the DeleteRoom service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        DeleteRoomResponse DeleteRoom(DeleteRoomRequest request);



        /// <summary>
        /// Deletes the specified room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRoom service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        Task<DeleteRoomResponse> DeleteRoomAsync(DeleteRoomRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisconnectUser


        /// <summary>
        /// Disconnects all connections using a specified user ID from a room. This replicates
        /// the <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/actions-disconnectuser-publish.html">
        /// DisconnectUser</a> WebSocket operation in the Amazon IVS Chat Messaging API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectUser service method.</param>
        /// 
        /// <returns>The response from the DisconnectUser service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DisconnectUser">REST API Reference for DisconnectUser Operation</seealso>
        DisconnectUserResponse DisconnectUser(DisconnectUserRequest request);



        /// <summary>
        /// Disconnects all connections using a specified user ID from a room. This replicates
        /// the <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/actions-disconnectuser-publish.html">
        /// DisconnectUser</a> WebSocket operation in the Amazon IVS Chat Messaging API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisconnectUser service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DisconnectUser">REST API Reference for DisconnectUser Operation</seealso>
        Task<DisconnectUserResponse> DisconnectUserAsync(DisconnectUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRoom


        /// <summary>
        /// Gets the specified room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoom service method.</param>
        /// 
        /// <returns>The response from the GetRoom service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/GetRoom">REST API Reference for GetRoom Operation</seealso>
        GetRoomResponse GetRoom(GetRoomRequest request);



        /// <summary>
        /// Gets the specified room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRoom service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/GetRoom">REST API Reference for GetRoom Operation</seealso>
        Task<GetRoomResponse> GetRoomAsync(GetRoomRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRooms


        /// <summary>
        /// Gets summary information about all your rooms in the AWS region where the API request
        /// is processed. Results are sorted in descending order of <code>updateTime</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRooms service method.</param>
        /// 
        /// <returns>The response from the ListRooms service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/ListRooms">REST API Reference for ListRooms Operation</seealso>
        ListRoomsResponse ListRooms(ListRoomsRequest request);



        /// <summary>
        /// Gets summary information about all your rooms in the AWS region where the API request
        /// is processed. Results are sorted in descending order of <code>updateTime</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRooms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRooms service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/ListRooms">REST API Reference for ListRooms Operation</seealso>
        Task<ListRoomsResponse> ListRoomsAsync(ListRoomsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets information about AWS tags for the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Gets information about AWS tags for the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendEvent


        /// <summary>
        /// Sends an event to a room. Use this within your application’s business logic to send
        /// events to clients of a room; e.g., to notify clients to change the way the chat UI
        /// is rendered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEvent service method.</param>
        /// 
        /// <returns>The response from the SendEvent service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/SendEvent">REST API Reference for SendEvent Operation</seealso>
        SendEventResponse SendEvent(SendEventRequest request);



        /// <summary>
        /// Sends an event to a room. Use this within your application’s business logic to send
        /// events to clients of a room; e.g., to notify clients to change the way the chat UI
        /// is rendered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendEvent service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/SendEvent">REST API Reference for SendEvent Operation</seealso>
        Task<SendEventResponse> SendEventAsync(SendEventRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or updates tags for the AWS resource with the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds or updates tags for the AWS resource with the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the resource with the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from the resource with the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRoom


        /// <summary>
        /// Updates a room’s configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoom service method.</param>
        /// 
        /// <returns>The response from the UpdateRoom service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        UpdateRoomResponse UpdateRoom(UpdateRoomRequest request);



        /// <summary>
        /// Updates a room’s configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoom service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        Task<UpdateRoomResponse> UpdateRoomAsync(UpdateRoomRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}