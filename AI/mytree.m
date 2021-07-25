classdef mytree
    methods(Static)
        
        % Summary
        
        % When using a decsion tree to analyse data you do not need to
        % compress the data by using normalisation or Z-score
        % standardisation as simple greater than or smaller then tests are
        % thee basis of the classification process, so refining the data in
        % this way will have no effect.
        
        % Decision trees start with a single node and the data dumped into
        % this, we then use Axis-parallel spits to seperate examples from
        % different classes (Think branches of the tree), to split the node
        % and purify the node have the majority of the data be from one
        % class, each time the node is split every possible decision is
        % checked as to what will purify the node the best and then this is
        % set as a question to ask any new testing examples, if splitting
        % the node would not further purify the nodes then they should not
        % be split. Intrestingly though every possible question that can 
        % be asked is assesed some features may never be used if the dont 
        % refine the data well enough (provide any useful information).This 
        % is a recursive function that continues until the node can no 
        % longer be splt (Expanded on below). 
                
        % Gini's Diversity index is used to identiy how pure a node is on a
        % scale of 0-1 the closer to zero (the less variation in class lables)
        % the more pure a node is considered to be.
        
        % Restrictions are placed onto the debth a decison tree can grow as
        % if the become too deep there is a risk of overfitting the
        % training data, such as having a minimum size limit before
        % a node is allowed to split. Without restrictions it would be
        % possible for the tree to box out every example into its own leaf
        % (Think low k value, KNN)> This also has the same inverse problem
        % and that with too much restriction we risk underfitting the
        % data.
        
        % When classifying a new testing example, the example is run
        % through the decision tree unitl it reaches the end of a branch,
        % (leaf node) testing against each decision made to generate the tree.
        % it then takes on the most common class label from that node.
        % Classifying new testing examples will be a fast process, though
        % building the tree in the training phase could potentially have
        % massive numbers of calculations required, testing 10 exmples 
        % against a tree that has 500 training examples and contains 10
        % branch nodes will take between 10-100 comparisons (1-10 
        % comparisons per test)*10 tests, as a leaf node could be at any
        % point down the tree.
       
        function m = fit(train_examples, train_labels)
            % The section below defines an empty node that can be reused
            % to create all of the nodes within the tree.
			
            % the unique number to represent the node
            emptyNode.number = [];
            % training data associated with the node
            emptyNode.examples = [];
            emptyNode.labels = [];
            % class prediction based on the class labels held by the node
            emptyNode.prediction = [];
            % a number represining the impurity of the class labels 
            % (Quantitys of different labels) 
            emptyNode.impurityMeasure = [];
            % if node is split then then the information will be divided
            % and stored into the two child nodes
            emptyNode.children = {};
            % the infomation that will define the split
            emptyNode.splitFeature = [];
            emptyNode.splitFeatureName = [];
            emptyNode.splitValue = [];

            m.emptyNode = emptyNode;
            
            % Initial set up of the model creating an empty node at the
            % top of the structure then copying all training examples and
            % labels, generating a class label for the node. This will
            % classify new data if the node isnt split
            r = emptyNode;
            r.number = 1;
            r.labels = train_labels;
            r.examples = train_examples;
            r.prediction = mode(r.labels);
            
            % Further set up parameters including minimum
            % parent size (number of examples a node must contain before splitting)
            % class labels and feature labels within each example(column names)
            % current number of nodes and total number of training exaples
            % used to train the model
            m.min_parent_size = 10;
            m.unique_classes = unique(r.labels);
            m.feature_names = train_examples.Properties.VariableNames;
			m.nodes = 1;
            m.N = size(train_examples,1);
            
            % Now that data has been dumped into the first node this line
            % calls the trySplit function to generate the tree. This
            % function tests to see if the node can be split into child
            % nodes to reduce the impurity within the new nodes, this
            % fuction is recursive and will only return once it is no
            % longer able to split any more nodes
            m.tree = mytree.trySplit(m, r);

        end
        
        function node = trySplit(m, node)
            % basic check for minimum size to split(value set earlier)
            if size(node.examples, 1) < m.min_parent_size
				return
            end
            
            % Calculate current impurity within  the class labels
            node.impurityMeasure = mytree.weightedImpurity(m, node.labels);
            
            % This will check all the different ways of splitting the training data.
            % It will consider splitting on every feature and unique feature
            % value of the training data. This will check every possible
            % division of the class labels and then split with the most "pure data".
            for i=1:size(node.examples,2)

				fprintf('evaluating possible splits on feature %d/%d\n', i, size(node.examples,2));
                
				[ps,n] = sortrows(node.examples,i);
                ls = node.labels(n);
                biggest_reduction(i) = -Inf;
                biggest_reduction_index(i) = -1;
                biggest_reduction_value(i) = NaN;
                for j=1:(size(ps,1)-1)
                    if ps{j,i} == ps{j+1,i}
                        continue;
                    end
                    
                    this_reduction = node.impurityMeasure - (mytree.weightedImpurity(m, ls(1:j)) + mytree.weightedImpurity(m, ls((j+1):end)));
                    
                    if this_reduction > biggest_reduction(i)
                        biggest_reduction(i) = this_reduction;
                        biggest_reduction_index(i) = j;
                    end
                end
				
            end

            [winning_reduction,winning_feature] = max(biggest_reduction);
            winning_index = biggest_reduction_index(winning_feature);

            if winning_reduction <= 0
                return
            else

                [ps,n] = sortrows(node.examples,winning_feature);
                ls = node.labels(n);

                node.splitFeature = winning_feature;
                node.splitFeatureName = m.feature_names{winning_feature};
                node.splitValue = (ps{winning_index,winning_feature} + ps{winning_index+1,winning_feature}) / 2;

                node.examples = [];
                node.labels = []; 
                node.prediction = [];

                node.children{1} = m.emptyNode;
                m.nodes = m.nodes + 1; 
                node.children{1}.number = m.nodes;
                node.children{1}.examples = ps(1:winning_index,:); 
                node.children{1}.labels = ls(1:winning_index);
                node.children{1}.prediction = mode(node.children{1}.labels);
                
                node.children{2} = m.emptyNode;
                m.nodes = m.nodes + 1; 
                node.children{2}.number = m.nodes;
                node.children{2}.examples = ps((winning_index+1):end,:); 
                node.children{2}.labels = ls((winning_index+1):end);
                node.children{2}.prediction = mode(node.children{2}.labels);
                
                node.children{1} = mytree.trySplit(m, node.children{1});
                node.children{2} = mytree.trySplit(m, node.children{2});
            end

        end
        
        % This uses Gini's diversity index GDI to determine the purity of
        % the node, this returns a value between 0-1 the closer to 0 the
        % more pure the node is considered(fewer class labels)
        function e = weightedImpurity(m, labels)

            weight = length(labels) / m.N;

            summ = 0;
            obsInThisNode = length(labels);
            for i=1:length(m.unique_classes)
                
				pi = length(labels(labels==m.unique_classes(i))) / obsInThisNode;
                summ = summ + (pi*pi);
            
			end
            g = 1 - summ;
            
            e = weight * g;

        end
        
        % Moves down the tree untill it reaches an end and then returns
        % with the most common class of the node.
        function predictions = predict(m, test_examples)

            predictions = categorical;
            
            for i=1:size(test_examples,1)
                
				fprintf('classifying example %i/%i\n', i, size(test_examples,1));
                this_test_example = test_examples{i,:};
                this_prediction = mytree.predict_one(m, this_test_example);
                predictions(end+1) = this_prediction;
            
			end
        end

        function prediction = predict_one(m, this_test_example)
            
			node = mytree.descend_tree(m.tree, this_test_example);
            prediction = node.prediction;
        
        end
        
        % Tree traversal
        function node = descend_tree(node, this_test_example)
            
			if isempty(node.children)
                return;
            else
                if this_test_example(node.splitFeature) < node.splitValue
                    node = mytree.descend_tree(node.children{1}, this_test_example);
                else
                    node = mytree.descend_tree(node.children{2}, this_test_example);
                end
            end
        
		end
        
        % describe a tree:
        function describeNode(node)
            
			if isempty(node.children)
                fprintf('Node %d; %s\n', node.number, node.prediction);
            else
                fprintf('Node %d; if %s <= %f then node %d else node %d\n', node.number, node.splitFeatureName, node.splitValue, node.children{1}.number, node.children{2}.number);
                mytree.describeNode(node.children{1});
                mytree.describeNode(node.children{2});        
            end
        
		end
		
    end
end