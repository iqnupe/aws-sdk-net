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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Ivschat.Model;
using Amazon.Ivschat.Model.Internal.MarshallTransformations;
using Amazon.Ivschat.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Ivschat
{
    /// <summary>
    /// Implementation for accessing Ivschat
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
    public partial class AmazonIvschatClient : AmazonServiceClient, IAmazonIvschat
    {
        private static IServiceMetadata serviceMetadata = new AmazonIvschatMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonIvschatClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonIvschatClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIvschatConfig()) { }

        /// <summary>
        /// Constructs AmazonIvschatClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonIvschatClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIvschatConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIvschatClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonIvschatClient Configuration Object</param>
        public AmazonIvschatClient(AmazonIvschatConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonIvschatClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIvschatClient(AWSCredentials credentials)
            : this(credentials, new AmazonIvschatConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIvschatClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIvschatClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIvschatConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIvschatClient with AWS Credentials and an
        /// AmazonIvschatClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIvschatClient Configuration Object</param>
        public AmazonIvschatClient(AWSCredentials credentials, AmazonIvschatConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIvschatClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIvschatClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIvschatConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIvschatClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIvschatClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIvschatConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIvschatClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIvschatClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIvschatClient Configuration Object</param>
        public AmazonIvschatClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIvschatConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIvschatClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIvschatClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIvschatConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIvschatClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIvschatClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIvschatConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIvschatClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIvschatClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIvschatClient Configuration Object</param>
        public AmazonIvschatClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIvschatConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IIvschatPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIvschatPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IvschatPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CreateChatToken

        internal virtual CreateChatTokenResponse CreateChatToken(CreateChatTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChatTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChatTokenResponseUnmarshaller.Instance;

            return Invoke<CreateChatTokenResponse>(request, options);
        }



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
        public virtual Task<CreateChatTokenResponse> CreateChatTokenAsync(CreateChatTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChatTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChatTokenResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChatTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRoom

        internal virtual CreateRoomResponse CreateRoom(CreateRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoomResponseUnmarshaller.Instance;

            return Invoke<CreateRoomResponse>(request, options);
        }



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
        public virtual Task<CreateRoomResponse> CreateRoomAsync(CreateRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoomResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRoomResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMessage

        internal virtual DeleteMessageResponse DeleteMessage(DeleteMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessageResponseUnmarshaller.Instance;

            return Invoke<DeleteMessageResponse>(request, options);
        }



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
        public virtual Task<DeleteMessageResponse> DeleteMessageAsync(DeleteMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMessageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoom

        internal virtual DeleteRoomResponse DeleteRoom(DeleteRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoomResponseUnmarshaller.Instance;

            return Invoke<DeleteRoomResponse>(request, options);
        }



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
        public virtual Task<DeleteRoomResponse> DeleteRoomAsync(DeleteRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoomResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRoomResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisconnectUser

        internal virtual DisconnectUserResponse DisconnectUser(DisconnectUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectUserResponseUnmarshaller.Instance;

            return Invoke<DisconnectUserResponse>(request, options);
        }



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
        public virtual Task<DisconnectUserResponse> DisconnectUserAsync(DisconnectUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectUserResponseUnmarshaller.Instance;

            return InvokeAsync<DisconnectUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRoom

        internal virtual GetRoomResponse GetRoom(GetRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoomResponseUnmarshaller.Instance;

            return Invoke<GetRoomResponse>(request, options);
        }



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
        public virtual Task<GetRoomResponse> GetRoomAsync(GetRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoomResponseUnmarshaller.Instance;

            return InvokeAsync<GetRoomResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRooms

        internal virtual ListRoomsResponse ListRooms(ListRoomsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoomsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoomsResponseUnmarshaller.Instance;

            return Invoke<ListRoomsResponse>(request, options);
        }



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
        public virtual Task<ListRoomsResponse> ListRoomsAsync(ListRoomsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoomsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoomsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRoomsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendEvent

        internal virtual SendEventResponse SendEvent(SendEventRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEventResponseUnmarshaller.Instance;

            return Invoke<SendEventResponse>(request, options);
        }



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
        public virtual Task<SendEventResponse> SendEventAsync(SendEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEventResponseUnmarshaller.Instance;

            return InvokeAsync<SendEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRoom

        internal virtual UpdateRoomResponse UpdateRoom(UpdateRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoomResponseUnmarshaller.Instance;

            return Invoke<UpdateRoomResponse>(request, options);
        }



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
        public virtual Task<UpdateRoomResponse> UpdateRoomAsync(UpdateRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoomResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRoomResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}