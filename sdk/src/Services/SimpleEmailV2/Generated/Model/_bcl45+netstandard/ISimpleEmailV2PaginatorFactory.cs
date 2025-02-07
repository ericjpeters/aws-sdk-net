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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Paginators for the SimpleEmailV2 service
    ///</summary>
    public interface ISimpleEmailV2PaginatorFactory
    {

        /// <summary>
        /// Paginator for GetDedicatedIps operation
        ///</summary>
        IGetDedicatedIpsPaginator GetDedicatedIps(GetDedicatedIpsRequest request);

        /// <summary>
        /// Paginator for ListConfigurationSets operation
        ///</summary>
        IListConfigurationSetsPaginator ListConfigurationSets(ListConfigurationSetsRequest request);

        /// <summary>
        /// Paginator for ListContactLists operation
        ///</summary>
        IListContactListsPaginator ListContactLists(ListContactListsRequest request);

        /// <summary>
        /// Paginator for ListContacts operation
        ///</summary>
        IListContactsPaginator ListContacts(ListContactsRequest request);

        /// <summary>
        /// Paginator for ListCustomVerificationEmailTemplates operation
        ///</summary>
        IListCustomVerificationEmailTemplatesPaginator ListCustomVerificationEmailTemplates(ListCustomVerificationEmailTemplatesRequest request);

        /// <summary>
        /// Paginator for ListDedicatedIpPools operation
        ///</summary>
        IListDedicatedIpPoolsPaginator ListDedicatedIpPools(ListDedicatedIpPoolsRequest request);

        /// <summary>
        /// Paginator for ListDeliverabilityTestReports operation
        ///</summary>
        IListDeliverabilityTestReportsPaginator ListDeliverabilityTestReports(ListDeliverabilityTestReportsRequest request);

        /// <summary>
        /// Paginator for ListDomainDeliverabilityCampaigns operation
        ///</summary>
        IListDomainDeliverabilityCampaignsPaginator ListDomainDeliverabilityCampaigns(ListDomainDeliverabilityCampaignsRequest request);

        /// <summary>
        /// Paginator for ListEmailIdentities operation
        ///</summary>
        IListEmailIdentitiesPaginator ListEmailIdentities(ListEmailIdentitiesRequest request);

        /// <summary>
        /// Paginator for ListEmailTemplates operation
        ///</summary>
        IListEmailTemplatesPaginator ListEmailTemplates(ListEmailTemplatesRequest request);

        /// <summary>
        /// Paginator for ListImportJobs operation
        ///</summary>
        IListImportJobsPaginator ListImportJobs(ListImportJobsRequest request);

        /// <summary>
        /// Paginator for ListRecommendations operation
        ///</summary>
        IListRecommendationsPaginator ListRecommendations(ListRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListSuppressedDestinations operation
        ///</summary>
        IListSuppressedDestinationsPaginator ListSuppressedDestinations(ListSuppressedDestinationsRequest request);
    }
}