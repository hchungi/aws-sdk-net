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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Shield.Model;

namespace Amazon.Shield
{
    /// <summary>
    /// Interface for accessing Shield
    ///
    /// AWS Shield Advanced 
    /// <para>
    /// This is the <i>AWS Shield Advanced API Reference</i>. This guide is for developers
    /// who need detailed information about the AWS Shield Advanced API actions, data types,
    /// and errors. For detailed information about AWS WAF and AWS Shield Advanced features
    /// and an overview of how to use the AWS WAF and AWS Shield Advanced APIs, see the <a
    /// href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF and AWS Shield
    /// Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonShield : IAmazonService, IDisposable
    {

        
        #region  CreateProtection


        /// <summary>
        /// Enables AWS Shield Advanced for a specific AWS resource. The resource can be an Amazon
        /// CloudFront distribution, Elastic Load Balancing load balancer, or an Amazon Route
        /// 53 hosted zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProtection service method.</param>
        /// 
        /// <returns>The response from the CreateProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidResourceException">
        /// Exception that indicates that the resource is invalid. You might not have access to
        /// the resource, or the resource might not exist.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LimitsExceededException">
        /// Exception that indicates that the operation would exceed a limit.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        CreateProtectionResponse CreateProtection(CreateProtectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProtection operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProtection
        ///         operation.</returns>
        IAsyncResult BeginCreateProtection(CreateProtectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProtection.</param>
        /// 
        /// <returns>Returns a  CreateProtectionResult from Shield.</returns>
        CreateProtectionResponse EndCreateProtection(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSubscription


        /// <summary>
        /// Activates AWS Shield Advanced for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceAlreadyExistsException">
        /// Exception indicating the specified resource already exists.
        /// </exception>
        CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscription
        ///         operation.</returns>
        IAsyncResult BeginCreateSubscription(CreateSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscription.</param>
        /// 
        /// <returns>Returns a  CreateSubscriptionResult from Shield.</returns>
        CreateSubscriptionResponse EndCreateSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProtection


        /// <summary>
        /// Deletes an AWS Shield Advanced <a>Protection</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtection service method.</param>
        /// 
        /// <returns>The response from the DeleteProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.OptimisticLockException">
        /// Exception that indicates that the protection state has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        DeleteProtectionResponse DeleteProtection(DeleteProtectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtection operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProtection
        ///         operation.</returns>
        IAsyncResult BeginDeleteProtection(DeleteProtectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProtection.</param>
        /// 
        /// <returns>Returns a  DeleteProtectionResult from Shield.</returns>
        DeleteProtectionResponse EndDeleteProtection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSubscription


        /// <summary>
        /// Removes AWS Shield Advanced from an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.LockedSubscriptionException">
        /// Exception that indicates that the subscription has been modified by another client.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        DeleteSubscriptionResponse DeleteSubscription(DeleteSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscription operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubscription
        ///         operation.</returns>
        IAsyncResult BeginDeleteSubscription(DeleteSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriptionResult from Shield.</returns>
        DeleteSubscriptionResponse EndDeleteSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAttack


        /// <summary>
        /// Describes the details of a DDoS attack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttack service method.</param>
        /// 
        /// <returns>The response from the DescribeAttack service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid.
        /// </exception>
        DescribeAttackResponse DescribeAttack(DescribeAttackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAttack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttack operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAttack
        ///         operation.</returns>
        IAsyncResult BeginDescribeAttack(DescribeAttackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAttack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAttack.</param>
        /// 
        /// <returns>Returns a  DescribeAttackResult from Shield.</returns>
        DescribeAttackResponse EndDescribeAttack(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProtection


        /// <summary>
        /// Lists the details of a <a>Protection</a> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtection service method.</param>
        /// 
        /// <returns>The response from the DescribeProtection service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        DescribeProtectionResponse DescribeProtection(DescribeProtectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtection operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProtection
        ///         operation.</returns>
        IAsyncResult BeginDescribeProtection(DescribeProtectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProtection.</param>
        /// 
        /// <returns>Returns a  DescribeProtectionResult from Shield.</returns>
        DescribeProtectionResponse EndDescribeProtection(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSubscription


        /// <summary>
        /// Provides details about the AWS Shield Advanced subscription for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscription service method.</param>
        /// 
        /// <returns>The response from the DescribeSubscription service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        DescribeSubscriptionResponse DescribeSubscription(DescribeSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscription operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSubscription
        ///         operation.</returns>
        IAsyncResult BeginDescribeSubscription(DescribeSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubscription.</param>
        /// 
        /// <returns>Returns a  DescribeSubscriptionResult from Shield.</returns>
        DescribeSubscriptionResponse EndDescribeSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAttacks


        /// <summary>
        /// Returns all ongoing DDoS attacks or all DDoS attacks during a specified time period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttacks service method.</param>
        /// 
        /// <returns>The response from the ListAttacks service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidOperationException">
        /// Exception that indicates that the operation would not cause any change to occur.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.InvalidParameterException">
        /// Exception that indicates that the parameters passed to the API are invalid.
        /// </exception>
        ListAttacksResponse ListAttacks(ListAttacksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttacks operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttacks
        ///         operation.</returns>
        IAsyncResult BeginListAttacks(ListAttacksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttacks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttacks.</param>
        /// 
        /// <returns>Returns a  ListAttacksResult from Shield.</returns>
        ListAttacksResponse EndListAttacks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProtections


        /// <summary>
        /// Lists all <a>Protection</a> objects for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtections service method.</param>
        /// 
        /// <returns>The response from the ListProtections service method, as returned by Shield.</returns>
        /// <exception cref="Amazon.Shield.Model.InternalErrorException">
        /// Exception that indicates that a problem occurred with the service infrastructure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.Shield.Model.ResourceNotFoundException">
        /// Exception indicating the specified resource does not exist.
        /// </exception>
        ListProtectionsResponse ListProtections(ListProtectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProtections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProtections operation on AmazonShieldClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProtections
        ///         operation.</returns>
        IAsyncResult BeginListProtections(ListProtectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProtections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProtections.</param>
        /// 
        /// <returns>Returns a  ListProtectionsResult from Shield.</returns>
        ListProtectionsResponse EndListProtections(IAsyncResult asyncResult);

        #endregion
        
    }
}