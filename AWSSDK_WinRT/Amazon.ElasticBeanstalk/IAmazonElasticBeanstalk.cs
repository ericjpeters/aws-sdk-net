/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.ElasticBeanstalk.Model;

namespace Amazon.ElasticBeanstalk
{
    /// <summary>
    /// Implementation for accessing ElasticBeanstalk
    /// 
    /// AWS Elastic Beanstalk
    /// <para>
    /// This is the AWS Elastic Beanstalk API Reference. This guide provides detailed
    /// information          about AWS Elastic Beanstalk actions, data types, parameters,
    /// and errors.
    /// </para>
    /// 
    /// <para>
    /// AWS Elastic Beanstalk         is a tool that makes it easy for you to create,
    /// deploy, and manage scalable, fault-tolerant applications running on         Amazon
    /// Web Services cloud resources.
    /// </para>
    /// 
    /// <para>
    /// For more information about this product, go to the <a href="http://aws.amazon.com/elasticbeanstalk/">AWS
    /// Elastic Beanstalk</a> details page.           The location of the latest AWS Elastic
    /// Beanstalk WSDL is          <a href="http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl">http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl</a>.
    /// 
    /// </para>
    /// 
    /// <para>
    /// <b>Endpoints</b>
    /// </para>
    /// 
    /// <para>
    /// For a list of region-specific endpoints that AWS Elastic Beanstalk supports, go to
    /// <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elasticbeanstalk_region">Regions
    /// and Endpoints</a> in the <i>Amazon Web Services Glossary</i>.
    /// </para>
    /// </summary>
	public partial interface IAmazonElasticBeanstalk : IDisposable
    {
 
        /// <summary>
        /// Checks if the specified CNAME is available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDNSAvailability service method.</param>
        /// 
        /// <returns>The response from the CheckDNSAvailability service method, as returned by ElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CheckDNSAvailabilityResponse> CheckDNSAvailabilityAsync(CheckDNSAvailabilityRequest checkDNSAvailabilityRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates an application that has one configuration         template named
        /// <code>default</code>         and no application versions.
        /// 
        /// The         &lt;code&gt;default&lt;/code&gt;         configuration template
        /// is for a 32-bit version of the         Amazon Linux         operating system running
        /// the Tomcat 6 application container.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyApplicationsException">
        /// The caller has exceeded the limit on the number of applications associated with their
        /// account.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest createApplicationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates an application version for the specified         application.
        /// 
        /// <note>Once you create an application version with a specified Amazon S3
        /// bucket         and key location, you cannot change that Amazon S3 location. If
        /// you change the         Amazon S3 location,         you receive an exception when you
        /// attempt to launch an environment from the         application version. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the CreateApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException">
        /// The specified S3 bucket does not belong to the S3 region in which the service is running.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyApplicationsException">
        /// The caller has exceeded the limit on the number of applications associated with their
        /// account.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyApplicationVersionsException">
        /// The caller has exceeded the limit on the number of application versions associated
        /// with their account.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateApplicationVersionResponse> CreateApplicationVersionAsync(CreateApplicationVersionRequest createApplicationVersionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates a configuration template. Templates are associated with a         specific
        /// application         and are used to deploy different versions of the         application
        /// with         the same configuration settings.
        /// 
        /// 
        /// <para>
        /// Related Topics
        /// </para>
        /// <ul>         <li>            <a>DescribeConfigurationOptions</a>         </li>
        /// <li>            <a>DescribeConfigurationSettings</a>         </li>
        /// <li>            <a>ListAvailableSolutionStacks</a>         </li>      </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyConfigurationTemplatesException">
        /// The caller has exceeded the limit on the number of configuration templates associated
        /// with their account.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateConfigurationTemplateResponse> CreateConfigurationTemplateAsync(CreateConfigurationTemplateRequest createConfigurationTemplateRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Launches an environment for the specified application using         the specified
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyEnvironmentsException">
        /// The caller has exceeded the limit of allowed environments associated with the account.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest createEnvironmentRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates the Amazon S3 storage location for the account.
        /// 
        /// 
        /// <para>
        /// This location is used to store user log files.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageLocation service method.</param>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException">
        /// The caller does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The web service attempted to create a bucket in an Amazon S3 account that already
        /// has 100 buckets.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateStorageLocationResponse> CreateStorageLocationAsync(CreateStorageLocationRequest createStorageLocationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified application along with all         associated versions
        /// and         configurations. The application versions will not be deleted from your
        /// Amazon S3 bucket.
        /// 
        /// <note>You cannot delete an application that has a running environment.
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation is already in
        /// progress affecting an an element in this activity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest deleteApplicationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified version from the specified         application.
        /// 
        /// 
        /// <note>You cannot delete an application version that is associated with a
        /// running environment.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation is already in
        /// progress affecting an an element in this activity.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException">
        /// The specified S3 bucket does not belong to the S3 region in which the service is running.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.SourceBundleDeletionException">
        /// Unable to delete the Amazon S3 source bundle associated with the application version,
        /// although the application version deleted successfully.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteApplicationVersionResponse> DeleteApplicationVersionAsync(DeleteApplicationVersionRequest deleteApplicationVersionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified configuration template.
        /// 
        /// <note>When you launch an environment using a configuration template, the
        /// environment         gets a copy of the template. You can delete or modify the
        /// environment's copy of         the template without         affecting the running environment.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation is already in
        /// progress affecting an an element in this activity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteConfigurationTemplateResponse> DeleteConfigurationTemplateAsync(DeleteConfigurationTemplateRequest deleteConfigurationTemplateRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the draft configuration associated with the running environment.
        /// 
        /// 
        /// <para>
        /// Updating a running environment with any configuration changes creates a
        /// draft configuration set. You can get the draft configuration using
        /// <a>DescribeConfigurationSettings</a> while the update is in progress          or if
        /// the update fails. The <code>DeploymentStatus</code> for the draft          configuration
        /// indicates whether the deployment is in process or has failed.         The draft configuration
        /// remains in existence until it is deleted with this action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentConfiguration service method, as returned by ElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteEnvironmentConfigurationResponse> DeleteEnvironmentConfigurationAsync(DeleteEnvironmentConfigurationRequest deleteEnvironmentConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications service method.</param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeApplicationsResponse> DescribeApplicationsAsync(DescribeApplicationsRequest describeApplicationsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns descriptions for existing application versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeApplicationVersionsResponse> DescribeApplicationVersionsAsync(DescribeApplicationVersionsRequest describeApplicationVersionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Describes the configuration options that are used in a         particular
        /// configuration template or environment, or that          a specified solution stack
        /// defines. The description includes the values the         options, their default values,
        /// and an indication of         the required action on a running environment if an option
        /// value is changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by ElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeConfigurationOptionsResponse> DescribeConfigurationOptionsAsync(DescribeConfigurationOptionsRequest describeConfigurationOptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns a description of the settings for the specified         configuration
        /// set, that is, either a configuration template or the         configuration set associated
        /// with a running environment.
        /// 
        /// 
        /// <para>
        /// When describing the settings for the configuration set associated with a
        /// running environment, it is possible to receive two sets of setting descriptions.
        /// One is the deployed configuration set, and the other is a draft configuration
        /// of an environment that is either in the process of deployment or that failed
        /// to         deploy.
        /// </para>
        /// 
        /// <para>
        /// Related Topics
        /// </para>
        /// <ul>         <li>            <a>DeleteEnvironmentConfiguration</a>         </li>
        /// </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationSettings service method, as returned by ElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeConfigurationSettingsResponse> DescribeConfigurationSettingsAsync(DescribeConfigurationSettingsRequest describeConfigurationSettingsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns AWS resources for this environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentResources service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentResources service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeEnvironmentResourcesResponse> DescribeEnvironmentResourcesAsync(DescribeEnvironmentResourcesRequest describeEnvironmentResourcesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeEnvironmentsResponse> DescribeEnvironmentsAsync(DescribeEnvironmentsRequest describeEnvironmentsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// 
        /// <note>         This action returns the most recent 1,000 events from the specified
        /// <code>NextToken</code>.      </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest describeEventsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns a list of the available solution stack names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableSolutionStacks service method.</param>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListAvailableSolutionStacksResponse> ListAvailableSolutionStacksAsync(ListAvailableSolutionStacksRequest listAvailableSolutionStacksRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes and recreates all of the AWS resources (for example: the Auto Scaling
        /// group, load         balancer, etc.)         for a specified environment and forces
        /// a restart.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebuildEnvironment service method.</param>
        /// 
        /// <returns>The response from the RebuildEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RebuildEnvironmentResponse> RebuildEnvironmentAsync(RebuildEnvironmentRequest rebuildEnvironmentRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Initiates a request to compile the specified type of         information
        /// of the deployed environment.
        /// 
        /// 
        /// <para>
        /// Setting the <code>InfoType</code> to <code>tail</code>         compiles the
        /// last lines from the application server log files of every         Amazon EC2 instance
        /// in your environment. Use <a>RetrieveEnvironmentInfo</a>         to access the compiled
        /// information.
        /// </para>
        /// 
        /// <para>
        /// Related Topics
        /// </para>
        /// <ul>                <li>            <a>RetrieveEnvironmentInfo</a>         </li>
        /// </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestEnvironmentInfo service method.</param>
        /// 
        /// <returns>The response from the RequestEnvironmentInfo service method, as returned by ElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RequestEnvironmentInfoResponse> RequestEnvironmentInfoAsync(RequestEnvironmentInfoRequest requestEnvironmentInfoRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Causes the environment to restart the application         container server
        /// running on each Amazon EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestartAppServer service method.</param>
        /// 
        /// <returns>The response from the RestartAppServer service method, as returned by ElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RestartAppServerResponse> RestartAppServerAsync(RestartAppServerRequest restartAppServerRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Retrieves the compiled information from a         <a>RequestEnvironmentInfo</a>
        /// request.
        /// 
        /// 
        /// <para>
        /// Related Topics
        /// </para>
        /// <ul>             <li>            <a>RequestEnvironmentInfo</a>         </li>
        /// </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveEnvironmentInfo service method.</param>
        /// 
        /// <returns>The response from the RetrieveEnvironmentInfo service method, as returned by ElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RetrieveEnvironmentInfoResponse> RetrieveEnvironmentInfoAsync(RetrieveEnvironmentInfoRequest retrieveEnvironmentInfoRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Swaps the CNAMEs of two environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs service method.</param>
        /// 
        /// <returns>The response from the SwapEnvironmentCNAMEs service method, as returned by ElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SwapEnvironmentCNAMEsResponse> SwapEnvironmentCNAMEsAsync(SwapEnvironmentCNAMEsRequest swapEnvironmentCNAMEsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Terminates the specified environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateEnvironment service method.</param>
        /// 
        /// <returns>The response from the TerminateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<TerminateEnvironmentResponse> TerminateEnvironmentAsync(TerminateEnvironmentRequest terminateEnvironmentRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Updates the specified application to have the specified         properties.
        /// 
        /// <note>         If a property (for example, <code>description</code>) is not
        /// provided, the         value         remains unchanged. To clear these properties,
        /// specify an empty string.      </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest updateApplicationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Updates the specified application version to have the specified         properties.
        /// 
        /// 
        /// <note>         If a property (for example,         <code>description</code>)
        /// is not provided, the         value remains unchanged. To clear properties,
        /// specify an empty string.      </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateApplicationVersionResponse> UpdateApplicationVersionAsync(UpdateApplicationVersionRequest updateApplicationVersionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Updates the specified configuration template to have the specified
        /// properties or configuration option values.
        /// 
        /// <note>         If a property (for example,         <code>ApplicationName</code>)
        /// is not provided, its         value remains unchanged. To clear such         properties,
        /// specify an empty string.      </note>
        /// <para>
        /// Related Topics
        /// </para>
        /// <ul>         <li>            <a>DescribeConfigurationOptions</a>         </li>
        /// </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateConfigurationTemplateResponse> UpdateConfigurationTemplateAsync(UpdateConfigurationTemplateRequest updateConfigurationTemplateRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Updates the environment description, deploys a new application         version,
        /// updates the configuration settings to an entirely new configuration         template,
        /// or updates select configuration option values in the running         environment.
        /// 
        /// 
        /// <para>
        /// Attempting to update both the release and configuration is         not allowed
        /// and AWS Elastic Beanstalk         returns an         <code>InvalidParameterCombination</code>
        /// error.
        /// </para>
        /// 
        /// <para>
        /// When updating the configuration settings to a new template or         individual
        /// settings,         a draft configuration is created and         <a>DescribeConfigurationSettings</a>
        /// for this         environment returns two setting descriptions with different
        /// <code>DeploymentStatus</code>         values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest updateEnvironmentRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Takes a set of configuration settings and either a configuration
        /// template or environment, and determines whether those values are valid.
        /// 
        /// 
        /// <para>
        /// This action returns a list of messages indicating any errors or warnings
        /// associated         with the selection of option values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfigurationSettings service method.</param>
        /// 
        /// <returns>The response from the ValidateConfigurationSettings service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ValidateConfigurationSettingsResponse> ValidateConfigurationSettingsAsync(ValidateConfigurationSettingsRequest validateConfigurationSettingsRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
