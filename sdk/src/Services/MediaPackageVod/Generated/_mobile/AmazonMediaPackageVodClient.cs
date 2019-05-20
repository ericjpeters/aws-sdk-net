/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MediaPackageVod.Model;
using Amazon.MediaPackageVod.Model.Internal.MarshallTransformations;
using Amazon.MediaPackageVod.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MediaPackageVod
{
    /// <summary>
    /// Implementation for accessing MediaPackageVod
    ///
    /// AWS Elemental MediaPackage VOD
    /// </summary>
    public partial class AmazonMediaPackageVodClient : AmazonServiceClient, IAmazonMediaPackageVod
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaPackageVodMetadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with the credentials loaded from the application's
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
        public AmazonMediaPackageVodClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaPackageVodConfig()) { }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with the credentials loaded from the application's
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
        public AmazonMediaPackageVodClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaPackageVodConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMediaPackageVodClient Configuration Object</param>
        public AmazonMediaPackageVodClient(AmazonMediaPackageVodConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMediaPackageVodClient(AWSCredentials credentials)
            : this(credentials, new AmazonMediaPackageVodConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaPackageVodClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMediaPackageVodConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Credentials and an
        /// AmazonMediaPackageVodClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMediaPackageVodClient Configuration Object</param>
        public AmazonMediaPackageVodClient(AWSCredentials credentials, AmazonMediaPackageVodConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMediaPackageVodClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaPackageVodConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaPackageVodClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaPackageVodConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaPackageVodClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMediaPackageVodClient Configuration Object</param>
        public AmazonMediaPackageVodClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMediaPackageVodConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMediaPackageVodClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaPackageVodConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaPackageVodClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaPackageVodConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageVodClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaPackageVodClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMediaPackageVodClient Configuration Object</param>
        public AmazonMediaPackageVodClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMediaPackageVodConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

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


        #region  CreateAsset

        internal virtual CreateAssetResponse CreateAsset(CreateAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetResponseUnmarshaller.Instance;

            return Invoke<CreateAssetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        public virtual Task<CreateAssetResponse> CreateAssetAsync(CreateAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePackagingConfiguration

        internal virtual CreatePackagingConfigurationResponse CreatePackagingConfiguration(CreatePackagingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePackagingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackagingConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreatePackagingConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePackagingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePackagingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreatePackagingConfiguration">REST API Reference for CreatePackagingConfiguration Operation</seealso>
        public virtual Task<CreatePackagingConfigurationResponse> CreatePackagingConfigurationAsync(CreatePackagingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePackagingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackagingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePackagingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePackagingGroup

        internal virtual CreatePackagingGroupResponse CreatePackagingGroup(CreatePackagingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePackagingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackagingGroupResponseUnmarshaller.Instance;

            return Invoke<CreatePackagingGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePackagingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePackagingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/CreatePackagingGroup">REST API Reference for CreatePackagingGroup Operation</seealso>
        public virtual Task<CreatePackagingGroupResponse> CreatePackagingGroupAsync(CreatePackagingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePackagingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackagingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePackagingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAsset

        internal virtual DeleteAssetResponse DeleteAsset(DeleteAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual Task<DeleteAssetResponse> DeleteAssetAsync(DeleteAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePackagingConfiguration

        internal virtual DeletePackagingConfigurationResponse DeletePackagingConfiguration(DeletePackagingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePackagingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackagingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeletePackagingConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePackagingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePackagingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeletePackagingConfiguration">REST API Reference for DeletePackagingConfiguration Operation</seealso>
        public virtual Task<DeletePackagingConfigurationResponse> DeletePackagingConfigurationAsync(DeletePackagingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePackagingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackagingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePackagingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePackagingGroup

        internal virtual DeletePackagingGroupResponse DeletePackagingGroup(DeletePackagingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePackagingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackagingGroupResponseUnmarshaller.Instance;

            return Invoke<DeletePackagingGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePackagingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePackagingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DeletePackagingGroup">REST API Reference for DeletePackagingGroup Operation</seealso>
        public virtual Task<DeletePackagingGroupResponse> DeletePackagingGroupAsync(DeletePackagingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePackagingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackagingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePackagingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAsset

        internal virtual DescribeAssetResponse DescribeAsset(DescribeAssetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAsset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribeAsset">REST API Reference for DescribeAsset Operation</seealso>
        public virtual Task<DescribeAssetResponse> DescribeAssetAsync(DescribeAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePackagingConfiguration

        internal virtual DescribePackagingConfigurationResponse DescribePackagingConfiguration(DescribePackagingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackagingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackagingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribePackagingConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackagingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackagingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribePackagingConfiguration">REST API Reference for DescribePackagingConfiguration Operation</seealso>
        public virtual Task<DescribePackagingConfigurationResponse> DescribePackagingConfigurationAsync(DescribePackagingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackagingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackagingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePackagingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePackagingGroup

        internal virtual DescribePackagingGroupResponse DescribePackagingGroup(DescribePackagingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackagingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackagingGroupResponseUnmarshaller.Instance;

            return Invoke<DescribePackagingGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackagingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackagingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/DescribePackagingGroup">REST API Reference for DescribePackagingGroup Operation</seealso>
        public virtual Task<DescribePackagingGroupResponse> DescribePackagingGroupAsync(DescribePackagingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackagingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackagingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePackagingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssets

        internal virtual ListAssetsResponse ListAssets(ListAssetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetsResponseUnmarshaller.Instance;

            return Invoke<ListAssetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListAssets">REST API Reference for ListAssets Operation</seealso>
        public virtual Task<ListAssetsResponse> ListAssetsAsync(ListAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPackagingConfigurations

        internal virtual ListPackagingConfigurationsResponse ListPackagingConfigurations(ListPackagingConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackagingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListPackagingConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPackagingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackagingConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListPackagingConfigurations">REST API Reference for ListPackagingConfigurations Operation</seealso>
        public virtual Task<ListPackagingConfigurationsResponse> ListPackagingConfigurationsAsync(ListPackagingConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackagingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagingConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPackagingConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPackagingGroups

        internal virtual ListPackagingGroupsResponse ListPackagingGroups(ListPackagingGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackagingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagingGroupsResponseUnmarshaller.Instance;

            return Invoke<ListPackagingGroupsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPackagingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackagingGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-vod-2018-11-07/ListPackagingGroups">REST API Reference for ListPackagingGroups Operation</seealso>
        public virtual Task<ListPackagingGroupsResponse> ListPackagingGroupsAsync(ListPackagingGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackagingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagingGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPackagingGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}