classdef myknn
    methods(Static)
        
        % Summary
        % 
        % Before KNN process is run data is cleaned up using
        % Z score standardisation (Think cloud -> sphere).
        % This process uses Standard deviation and means to 
        % shrink the data so that each feature has a comparable size.
        % It is done so that no one large data point can 
        % skew the results meaning that all axes have an equal 
        % contribution.
        %
        % KNN plots(Simple, not much processing, always fast) training
        % examples as coordiates in feature space (Multidimentional, 
        % with an axis for each feature).
        
        % Each testing example is compaired to every training  
        % example, the testing example then takes on the most common 
        % classification of the K(number of) Nearest Neighbours.         
        % The nearest neighbours are calculated as those with the 
        % shortest Euclidean distance (Straight Line).
        % 50 test, 1000 training with a K of 10(K dosnt effect calculation)
        % mean 50,000 calculations must take place, so the larger the
        % training data the slower the calculations.
        
        % K is the only hyperparameter(set before training), KNN doesnt 
        % learn any parameters during training. Choosing the correct value
        % for k is important as choosing a value to low (Overfitting)or 
        % high (Underfitting) can yeald poor results. Think low values 
        % can be classified the same as "noise" in the data when a larger
        % value of K will give a more accurate result. A good start is 
        % for the value of k is the square root of the numebr of items in 
        % the training data
        
        % Fit This is the process that re-scales each feature
        % in our training data to lie within comparable ranges.
        function m = fit(train_examples, train_labels, k)
            
            % start of standardisation process
            % mean works the average of all examples
			m.mean = mean(train_examples{:,:});
            % std works the standard deviation of the examples.
			m.std = std(train_examples{:,:});
            % this process reduces the values for each column by 
            % making its equal its difference to the mean.        
            % then each column is then right devided (./) by the standard
            % deviation. This whole process is so that the values arn't
            % dominated by values of a larger scale.
            % this process is called z-score standardisation
            for i=1:size(train_examples,1)
				train_examples{i,:} = train_examples{i,:} - m.mean;
                train_examples{i,:} = train_examples{i,:} ./ m.std;
            end
            % end of standardisation process
            
            % set the values of the correspondent fields
            m.train_examples = train_examples;
            m.train_labels = train_labels;
            m.k = k;
        
        end

        function predictions = predict(m, test_examples)

            predictions = categorical;

            for i=1:size(test_examples,1)
                
                fprintf('classifying example example %i/%i\n', i, size(test_examples,1));
                
                this_test_example = test_examples{i,:};
                
                % process of z-score standardisation using values from the
                % training data.
                % start of standardisation process
                this_test_example = this_test_example - m.mean;
                this_test_example = this_test_example ./ m.std;
                % end of standardisation process
                
                % prediction of each row item this is then added to a new
                % array. 
                this_prediction = myknn.predict_one(m, this_test_example);
                predictions(end+1) = this_prediction;
            
            end
        
		end

        function prediction = predict_one(m, this_test_example)
            % finds the K training exapmles with the shortest distance and
            % then  makes the prediction based on this
            distances = myknn.calculate_distances(m, this_test_example);
            neighbour_indices = myknn.find_nn_indices(m, distances);
            prediction = myknn.make_prediction(m, neighbour_indices);
        
        end

        function distances = calculate_distances(m, this_test_example)
            % actual calculation of distances
			distances = [];
            
			for i=1:size(m.train_examples,1)
                
				this_training_example = m.train_examples{i,:};
                this_distance = myknn.calculate_distance(this_training_example, this_test_example);
                distances(end+1) = this_distance;
            end
        
		end

        function distance = calculate_distance(p, q)
            
            % Uses pythagorus to work out the difference between each value
			differences = q - p;
            squares = differences .^ 2;
            total = sum(squares);
            distance = sqrt(total);
        
		end

        function neighbour_indices = find_nn_indices(m, distances)
            % sorts neighbours by distance
            
			[sorted, indices] = sort(distances);
            neighbour_indices = indices(1:m.k);
        
		end
        
        function prediction = make_prediction(m, neighbour_indices)
            % takes classification and assigns most common
			neighbour_labels = m.train_labels(neighbour_indices);
            prediction = mode(neighbour_labels);
        
		end

    end
end

