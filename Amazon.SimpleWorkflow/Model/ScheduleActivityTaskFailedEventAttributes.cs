/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Provides details of the <c>ScheduleActivityTaskFailed</c> event. </para>
    /// </summary>
    public class ScheduleActivityTaskFailedEventAttributes  
    {
        
        private ActivityType activityType;
        private string activityId;
        private string cause;
        private long? decisionTaskCompletedEventId;

        /// <summary>
        /// The activity type provided in the <c>ScheduleActivityTask</c> decision that failed.
        ///  
        /// </summary>
        public ActivityType ActivityType
        {
            get { return this.activityType; }
            set { this.activityType = value; }
        }

        /// <summary>
        /// Sets the ActivityType property
        /// </summary>
        /// <param name="activityType">The value to set for the ActivityType property </param>
        /// <returns>this instance</returns>
        public ScheduleActivityTaskFailedEventAttributes WithActivityType(ActivityType activityType)
        {
            this.activityType = activityType;
            return this;
        }
            

        // Check to see if ActivityType property is set
        internal bool IsSetActivityType()
        {
            return this.activityType != null;       
        }

        /// <summary>
        /// The activityId provided in the <c>ScheduleActivityTask</c> decision that failed.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ActivityId
        {
            get { return this.activityId; }
            set { this.activityId = value; }
        }

        /// <summary>
        /// Sets the ActivityId property
        /// </summary>
        /// <param name="activityId">The value to set for the ActivityId property </param>
        /// <returns>this instance</returns>
        public ScheduleActivityTaskFailedEventAttributes WithActivityId(string activityId)
        {
            this.activityId = activityId;
            return this;
        }
            

        // Check to see if ActivityId property is set
        internal bool IsSetActivityId()
        {
            return this.activityId != null;       
        }

        /// <summary>
        /// The cause of the failure to process the decision. This information is generated by the system and can be useful for diagnostic purposes.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ACTIVITY_TYPE_DEPRECATED, ACTIVITY_TYPE_DOES_NOT_EXIST, ACTIVITY_ID_ALREADY_IN_USE, OPEN_ACTIVITIES_LIMIT_EXCEEDED, ACTIVITY_CREATION_RATE_EXCEEDED, DEFAULT_SCHEDULE_TO_CLOSE_TIMEOUT_UNDEFINED, DEFAULT_TASK_LIST_UNDEFINED, DEFAULT_SCHEDULE_TO_START_TIMEOUT_UNDEFINED, DEFAULT_START_TO_CLOSE_TIMEOUT_UNDEFINED, DEFAULT_HEARTBEAT_TIMEOUT_UNDEFINED</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Cause
        {
            get { return this.cause; }
            set { this.cause = value; }
        }

        /// <summary>
        /// Sets the Cause property
        /// </summary>
        /// <param name="cause">The value to set for the Cause property </param>
        /// <returns>this instance</returns>
        public ScheduleActivityTaskFailedEventAttributes WithCause(string cause)
        {
            this.cause = cause;
            return this;
        }
            

        // Check to see if Cause property is set
        internal bool IsSetCause()
        {
            return this.cause != null;       
        }

        /// <summary>
        /// The id of the <c>DecisionTaskCompleted</c> event corresponding to the decision that resulted in the scheduling of this activity task. This
        /// information can be useful for diagnosing problems by tracing back the chain of events leading up to this event.
        ///  
        /// </summary>
        public long DecisionTaskCompletedEventId
        {
            get { return this.decisionTaskCompletedEventId ?? default(long); }
            set { this.decisionTaskCompletedEventId = value; }
        }

        /// <summary>
        /// Sets the DecisionTaskCompletedEventId property
        /// </summary>
        /// <param name="decisionTaskCompletedEventId">The value to set for the DecisionTaskCompletedEventId property </param>
        /// <returns>this instance</returns>
        public ScheduleActivityTaskFailedEventAttributes WithDecisionTaskCompletedEventId(long decisionTaskCompletedEventId)
        {
            this.decisionTaskCompletedEventId = decisionTaskCompletedEventId;
            return this;
        }
            

        // Check to see if DecisionTaskCompletedEventId property is set
        internal bool IsSetDecisionTaskCompletedEventId()
        {
            return this.decisionTaskCompletedEventId.HasValue;       
        }
    }
}
