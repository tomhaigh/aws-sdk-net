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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CodeBuild.Model;
using Amazon.CodeBuild.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CodeBuild
{
    /// <summary>
    /// Implementation for accessing CodeBuild
    ///
    /// AWS CodeBuild 
    /// <para>
    /// AWS CodeBuild is a fully managed build service in the cloud. AWS CodeBuild compiles
    /// your source code, runs unit tests, and produces artifacts that are ready to deploy.
    /// AWS CodeBuild eliminates the need to provision, manage, and scale your own build servers.
    /// It provides prepackaged build environments for the most popular programming languages
    /// and build tools, such as Apach Maven, Gradle, and more. You can also fully customize
    /// build environments in AWS CodeBuild to use your own build tools. AWS CodeBuild scales
    /// automatically to meet peak build requests, and you pay only for the build time you
    /// consume. For more information about AWS CodeBuild, see the <i>AWS CodeBuild User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// AWS CodeBuild supports these operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>BatchDeleteBuilds</code>: Deletes one or more builds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>BatchGetProjects</code>: Gets information about one or more build projects.
    /// A <i>build project</i> defines how AWS CodeBuild will run a build. This includes information
    /// such as where to get the source code to build, the build environment to use, the build
    /// commands to run, and where to store the build output. A <i>build environment</i> represents
    /// a combination of operating system, programming language runtime, and tools that AWS
    /// CodeBuild will use to run a build. Also, you can add tags to build projects to help
    /// manage your resources and costs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CreateProject</code>: Creates a build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteProject</code>: Deletes a build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListProjects</code>: Gets a list of build project names, with each build project
    /// name representing a single build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateProject</code>: Changes the settings of an existing build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>BatchGetBuilds</code>: Gets information about one or more builds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListBuilds</code>: Gets a list of build IDs, with each build ID representing
    /// a single build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListBuildsForProject</code>: Gets a list of build IDs for the specified build
    /// project, with each build ID representing a single build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>StartBuild</code>: Starts running a build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>StopBuild</code>: Attempts to stop running a build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListCuratedEnvironmentImages</code>: Gets information about Docker images that
    /// are managed by AWS CodeBuild.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonCodeBuildClient : AmazonServiceClient, IAmazonCodeBuild
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonCodeBuildClient with the credentials loaded from the application's
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
        public AmazonCodeBuildClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeBuildConfig()) { }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with the credentials loaded from the application's
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
        public AmazonCodeBuildClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeBuildConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCodeBuildClient Configuration Object</param>
        public AmazonCodeBuildClient(AmazonCodeBuildConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodeBuildClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodeBuildConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeBuildClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodeBuildConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Credentials and an
        /// AmazonCodeBuildClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodeBuildClient Configuration Object</param>
        public AmazonCodeBuildClient(AWSCredentials credentials, AmazonCodeBuildConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodeBuildClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeBuildConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeBuildClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeBuildConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeBuildClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodeBuildClient Configuration Object</param>
        public AmazonCodeBuildClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodeBuildConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodeBuildClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeBuildConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeBuildClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeBuildConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeBuildClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodeBuildClient Configuration Object</param>
        public AmazonCodeBuildClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodeBuildConfig clientConfig)
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

        
        #region  BatchDeleteBuilds

        internal BatchDeleteBuildsResponse BatchDeleteBuilds(BatchDeleteBuildsRequest request)
        {
            var marshaller = new BatchDeleteBuildsRequestMarshaller();
            var unmarshaller = BatchDeleteBuildsResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteBuildsRequest,BatchDeleteBuildsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteBuilds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBuilds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchDeleteBuilds">REST API Reference for BatchDeleteBuilds Operation</seealso>
        public Task<BatchDeleteBuildsResponse> BatchDeleteBuildsAsync(BatchDeleteBuildsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchDeleteBuildsRequestMarshaller();
            var unmarshaller = BatchDeleteBuildsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteBuildsRequest,BatchDeleteBuildsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchGetBuilds

        internal BatchGetBuildsResponse BatchGetBuilds(BatchGetBuildsRequest request)
        {
            var marshaller = new BatchGetBuildsRequestMarshaller();
            var unmarshaller = BatchGetBuildsResponseUnmarshaller.Instance;

            return Invoke<BatchGetBuildsRequest,BatchGetBuildsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetBuilds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuilds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuilds">REST API Reference for BatchGetBuilds Operation</seealso>
        public Task<BatchGetBuildsResponse> BatchGetBuildsAsync(BatchGetBuildsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchGetBuildsRequestMarshaller();
            var unmarshaller = BatchGetBuildsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetBuildsRequest,BatchGetBuildsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchGetProjects

        internal BatchGetProjectsResponse BatchGetProjects(BatchGetProjectsRequest request)
        {
            var marshaller = new BatchGetProjectsRequestMarshaller();
            var unmarshaller = BatchGetProjectsResponseUnmarshaller.Instance;

            return Invoke<BatchGetProjectsRequest,BatchGetProjectsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetProjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetProjects">REST API Reference for BatchGetProjects Operation</seealso>
        public Task<BatchGetProjectsResponse> BatchGetProjectsAsync(BatchGetProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchGetProjectsRequestMarshaller();
            var unmarshaller = BatchGetProjectsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetProjectsRequest,BatchGetProjectsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateProject

        internal CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var marshaller = new CreateProjectRequestMarshaller();
            var unmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectRequest,CreateProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateProjectRequestMarshaller();
            var unmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectRequest,CreateProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteProject

        internal DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var marshaller = new DeleteProjectRequestMarshaller();
            var unmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectRequest,DeleteProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteProjectRequestMarshaller();
            var unmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectRequest,DeleteProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListBuilds

        internal ListBuildsResponse ListBuilds(ListBuildsRequest request)
        {
            var marshaller = new ListBuildsRequestMarshaller();
            var unmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return Invoke<ListBuildsRequest,ListBuildsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListBuilds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        public Task<ListBuildsResponse> ListBuildsAsync(ListBuildsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListBuildsRequestMarshaller();
            var unmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBuildsRequest,ListBuildsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListBuildsForProject

        internal ListBuildsForProjectResponse ListBuildsForProject(ListBuildsForProjectRequest request)
        {
            var marshaller = new ListBuildsForProjectRequestMarshaller();
            var unmarshaller = ListBuildsForProjectResponseUnmarshaller.Instance;

            return Invoke<ListBuildsForProjectRequest,ListBuildsForProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListBuildsForProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuildsForProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildsForProject">REST API Reference for ListBuildsForProject Operation</seealso>
        public Task<ListBuildsForProjectResponse> ListBuildsForProjectAsync(ListBuildsForProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListBuildsForProjectRequestMarshaller();
            var unmarshaller = ListBuildsForProjectResponseUnmarshaller.Instance;

            return InvokeAsync<ListBuildsForProjectRequest,ListBuildsForProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCuratedEnvironmentImages

        internal ListCuratedEnvironmentImagesResponse ListCuratedEnvironmentImages(ListCuratedEnvironmentImagesRequest request)
        {
            var marshaller = new ListCuratedEnvironmentImagesRequestMarshaller();
            var unmarshaller = ListCuratedEnvironmentImagesResponseUnmarshaller.Instance;

            return Invoke<ListCuratedEnvironmentImagesRequest,ListCuratedEnvironmentImagesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListCuratedEnvironmentImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCuratedEnvironmentImages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListCuratedEnvironmentImages">REST API Reference for ListCuratedEnvironmentImages Operation</seealso>
        public Task<ListCuratedEnvironmentImagesResponse> ListCuratedEnvironmentImagesAsync(ListCuratedEnvironmentImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListCuratedEnvironmentImagesRequestMarshaller();
            var unmarshaller = ListCuratedEnvironmentImagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCuratedEnvironmentImagesRequest,ListCuratedEnvironmentImagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListProjects

        internal ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var marshaller = new ListProjectsRequestMarshaller();
            var unmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsRequest,ListProjectsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListProjectsRequestMarshaller();
            var unmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectsRequest,ListProjectsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartBuild

        internal StartBuildResponse StartBuild(StartBuildRequest request)
        {
            var marshaller = new StartBuildRequestMarshaller();
            var unmarshaller = StartBuildResponseUnmarshaller.Instance;

            return Invoke<StartBuildRequest,StartBuildResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBuild operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuild">REST API Reference for StartBuild Operation</seealso>
        public Task<StartBuildResponse> StartBuildAsync(StartBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartBuildRequestMarshaller();
            var unmarshaller = StartBuildResponseUnmarshaller.Instance;

            return InvokeAsync<StartBuildRequest,StartBuildResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopBuild

        internal StopBuildResponse StopBuild(StopBuildRequest request)
        {
            var marshaller = new StopBuildRequestMarshaller();
            var unmarshaller = StopBuildResponseUnmarshaller.Instance;

            return Invoke<StopBuildRequest,StopBuildResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopBuild operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuild">REST API Reference for StopBuild Operation</seealso>
        public Task<StopBuildResponse> StopBuildAsync(StopBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopBuildRequestMarshaller();
            var unmarshaller = StopBuildResponseUnmarshaller.Instance;

            return InvokeAsync<StopBuildRequest,StopBuildResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateProject

        internal UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var marshaller = new UpdateProjectRequestMarshaller();
            var unmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectRequest,UpdateProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateProjectRequestMarshaller();
            var unmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProjectRequest,UpdateProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}